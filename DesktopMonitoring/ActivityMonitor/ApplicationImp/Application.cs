using ActivityMonitor.Collections;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Automation;
using System.Xml.Serialization;

namespace ActivityMonitor.Application
{


    public class Application : IApplication, INotifyPropertyChanged
    {
        private string _path;
        private string _exeName;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public void Refresh()
        {
            NotifyPropertyChanged("TotalUsageTime");
        }


        public Application(ApplicationUsages usage = null)
        {

            Usage = usage ?? new ApplicationUsages();

        }

        public Application()
        {
            Usage = new ApplicationUsages();
        }

        public Application(string name, string path)
        {
            Path = path;
            Name = name;
            if (name.ToLower().Contains("chrome"))
            {
                App_Name = GetActiveTabUrl();
            }
            Usage = new ApplicationUsages();
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

        [XmlAttribute]
        public string Path
        {
            get => _path;

            set
            {
                FileInfo fi = new FileInfo(value);
                _exeName = fi.Name;
                _path = value;
            }
        }

        public string ExeName
        {
            get => _exeName;
        }

        [XmlAttribute]
        public string Name { get; set; }

        public long ApplicationID { get; set; }

        public TimeSpan TotalUsageTime
        {
            get { return Usage.TotalUsageTime(); }
        }

        public double TotalTimeInMinutes { get { return TotalUsageTime.TotalMinutes; } }

        private ApplicationUsages _usage;

        public ApplicationUsages Usage
        {
            get { return _usage; }
            set
            {
                _usage = value;
                NotifyPropertyChanged("Usage");
            }
        }

        [XmlIgnore]
        public Icon Icon { get; set; }

        public ApplicationDetails Details { get; set; }
        public string App_Name { get; set; }
    }
}
