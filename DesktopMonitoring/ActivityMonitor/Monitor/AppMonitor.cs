using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
//using System.Windows.Data;
//using System.Windows.Media;
//using System.Windows.Threading;
using Microsoft.Win32;
using ActivityMonitor.Application;
using System.Windows.Automation;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using ActivityMonitor.ApplicationImp;
//using AppMonitor.SettingsManager;

namespace ActivityMonitor.ApplicationMonitor
{
    public class AppMonitor : INotifyPropertyChanged
    {
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

        public int IdleTime => _idleTime;

        private readonly DateTime _startTime = DateTime.Now;

        public AppMonitor()//Dispatcher dispatcher)
        {
            Data = new Applications();
            _appUpdater = new AppUpdater(Data);
            _idleInterval = 30;

            Session = new UserSession();
            
            SystemEvents.SessionSwitch += SystemEventsSessionSwitch;
        }

        private bool _sessionStopped;
        public void SystemEventsSessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            switch (e.Reason)
            {
                case SessionSwitchReason.SessionLock:
                    _sessionStopped = true;
                    break;
                case SessionSwitchReason.SessionUnlock:
                    _sessionStopped = false;
                    break;
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
            if (!_started) { 
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
        public static string GetActiveTabUrl()
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


        private void ApplicationsUpdater()
        {
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(5);
            _started = true;
            while (!_requestStop) { 
            try
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                // Combine the base folder with your specific folder....
                string specificFolder = Path.Combine(folder, "DMSSnaps");
                 if (!Directory.Exists(specificFolder))
                 {
                        Directory.CreateDirectory(specificFolder);
                 }
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
                            var currentApplication = _appUpdater.Update(process, GetActiveTabUrl());
                            if (currentApplication != null)
                            {

            
    
    try
    {
        Bitmap captureBitmap = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);
        //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);
        //Creating a Rectangle object which will
        //capture our Current Screen
        Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
        //Creating a New Graphics Object
        Graphics captureGraphics = Graphics.FromImage(captureBitmap);
        //Copying Image from The Screen
        captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
        //Saving the Image File (I am here Saving it in My E drive).
        string fileName = System.DateTime.Now.ToString().Replace(@"/", "-").Replace(":", "-") + ".jpg";
        captureBitmap.Save(specificFolder + @"\" + fileName, ImageFormat.Jpeg);
        ApplicationScreenshots applicationScreenshots = new ApplicationScreenshots();
        applicationScreenshots.ScreenshotName = fileName;
        applicationScreenshots.SnapDatetime = System.DateTime.Now;
                                    currentApplication.Usage.FindLast(u => !u.IsClosed).AddScreenShot(applicationScreenshots);

    }catch(Exception ex)
    {

    }



                                CurrentApplicationName = currentApplication.Name;
                                CurrentApplicationTotalUsageTime = currentApplication.TotalUsageTime;
                                CurrentApplicationPath = currentApplication.Path;
                                CurrentApplicationIcon = currentApplication.Icon;
                                if (currentApplication.Name.Contains("chrome"))
                                {

                                }
                            }
                        }
                        else
                        {
                            var currentApplication = _appUpdater.Update(process,"");
                            if (currentApplication != null)
                            {


   
    try
    {
        Bitmap captureBitmap = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);
        //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);
        //Creating a Rectangle object which will
        //capture our Current Screen
        Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
        //Creating a New Graphics Object
        Graphics captureGraphics = Graphics.FromImage(captureBitmap);
        //Copying Image from The Screen
        captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
        //Saving the Image File (I am here Saving it in My E drive).
        string fileName = System.DateTime.Now.ToString().Replace(@"/", "-").Replace(":", "-") + ".jpg";
        captureBitmap.Save(specificFolder + @"\" + fileName, ImageFormat.Jpeg);
                                    ApplicationScreenshots applicationScreenshots = new ApplicationScreenshots();
                                    applicationScreenshots.ScreenshotName = fileName;
                                    applicationScreenshots.SnapDatetime = System.DateTime.Now;
                                    currentApplication.Usage.FindLast(u => !u.IsClosed).AddScreenShot(applicationScreenshots);

    }catch(Exception ex)
    {
      
    }


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
}