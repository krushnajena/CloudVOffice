using ActivityMonitor.Application;
using ActivityMonitor.ApplicationImp;
using ActivityMonitor.Collections;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Automation;

namespace ActivityMonitor.ApplicationMonitor
{
    public class AppUpdater
    {
        private static Applications _applications;
        private static FileLog _fileLog;

        private string _previousApplicationName = string.Empty;
        List<string> list = new List<string>();
        public static Applications Applications
        {
            set { _applications = value; }
        }

        public static FileLog fileLog
        {
            set { _fileLog = value; }
        }
        public static double GetMaxValue
        {
            get
            {
                return (from app in _applications
                        select app.TotalUsageTime.TotalSeconds).Max();
            }
        }

        public AppUpdater(Applications applications, FileLog fileLog)
        {
            _applications = applications;
            _fileLog = fileLog;
        }


        public void Stop(Process process)
        {
            try
            {

                if (_applications[_previousApplicationName] != null &&
                        _applications[_previousApplicationName].Usage.FindLast(u => !u.IsClosed) != null)
                {


                    _applications[_previousApplicationName].Usage.FindLast(u => !u.IsClosed).End();

                }

                var currentProcess = process.MainModule.FileVersionInfo.FileDescription;
                if (_applications[currentProcess] != null &&
                            _applications[currentProcess].Usage.FindLast(u => !u.IsClosed) != null)
                {
                    _applications[currentProcess].Usage.FindLast(u => !u.IsClosed).End();

                }
            }
            catch (Exception)
            {

                // todo logging
            }


        }

        private string DetectFilePath(Process lProcess)
        {
            // Detect File Path: Sometimes MainModule.FileVersionInfo is not reliable
            // so we switch detection to Win API 

            string strFileName = "";
            try
            {
                strFileName = lProcess.MainModule.FileVersionInfo.FileName;
            }
            catch (Exception)
            {
                strFileName = WinApi.GetProcessFilename(lProcess);
            }

            return strFileName;
        }

        private string DetectFileDescription(Process lProcess)
        {
            // Detect File Descriptiom: dealing with file description is a little time consuming
            // so for now that's rely on process name 

            string strFileDescription;
            try
            {
                strFileDescription = lProcess.MainModule.FileVersionInfo.FileDescription;
            }
            catch (Exception)
            {
                strFileDescription = lProcess.ProcessName;
            }
            return strFileDescription;
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
        public FileLog FileLogCreate(FileLog message)
        {
            _fileLog.Add(message);
            return message;
        }
        public IApplication Update(Process process, string appurl)
        {
            //Reliably detect the process file name:
            string strFileName = DetectFilePath(process);
            string strFileDescription = DetectFileDescription(process);

            try
            {



                if (_previousApplicationName != strFileDescription)
                {

                    if (_applications[_previousApplicationName] != null &&
                        _applications[_previousApplicationName].Usage.FindLast(u => !u.IsClosed) != null)
                    {
                        _applications[_previousApplicationName].Usage.FindLast(u => !u.IsClosed).End();

                    }

                    _previousApplicationName = strFileDescription;
                    string appname = "";
                    if (strFileDescription.ToLower().Contains("chrome"))
                    {
                        appname = GetActiveTabUrl();

                    }
                    else if (strFileDescription.ToLower().Contains("edge"))
                    {
                        appname = GetEdgeActiveTabUrl();

                    }

                    if (
                        !_applications.Contains(strFileDescription,
                                                strFileName, appname))
                    {
                        try
                        {
                            using (new MemoryStream())
                            {
                                var AppIcon = Icon.ExtractAssociatedIcon(strFileName);
                                _applications.Add(
                                new ActivityMonitor.Application.Application(strFileDescription, strFileName) { Icon = AppIcon });
                            }

                        }
                        catch (Exception ex)
                        {
                            //Console.WriteLine(ex.Message);
                            //todo logging
                        }
                    }

                    if (appname != "")
                    {
                        try
                        {
                            var usage = new ApplicationUsage { DetailedName = appname };
                            usage.Start();

                            _applications[strFileDescription].Usage.Add(usage);
                        }
                        catch (Exception ex)
                        {

                        }

                    }
                    else
                    {
                        try
                        {
                            var usage = new ApplicationUsage { DetailedName = process.MainWindowTitle };
                            usage.Start();
                            _applications[strFileDescription].Usage.Add(usage);
                        }
                        catch (Exception ex)
                        {

                        }
                    }


                }

                // if resume - no usages are present
                var currentProcess = strFileDescription;
                if (_applications[_previousApplicationName] != null &&
                    _applications[_previousApplicationName].Usage.FindLast(u => !u.IsClosed) == null &&
                    _applications[currentProcess] != null &&
                    _applications[currentProcess].Usage.FindLast(u => !u.IsClosed) == null)
                {
                    string appname = "";
                    if (strFileDescription.ToLower().Contains("chrome"))
                    {
                        appname = GetActiveTabUrl();

                    }
                    if (appname != "")
                    {
                        var usage = new ApplicationUsage { DetailedName = appname };
                        usage.Start();
                        _applications[strFileDescription].Usage.Add(usage);
                    }
                    else
                    {
                        var usage = new ApplicationUsage { DetailedName = process.MainWindowTitle };
                        usage.Start();
                        _applications[strFileDescription].Usage.Add(usage);
                    }

                }

            }
            catch (Exception ex)
            {
                //todo logging
                Console.WriteLine(ex.Message);
            }
            return _applications[_previousApplicationName];
        }

        protected IApplication CurrentApplication
        {
            get;
            private set;
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

    }

}