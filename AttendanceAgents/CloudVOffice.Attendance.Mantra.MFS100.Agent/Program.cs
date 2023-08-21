using CloudVOffice.Attendance.Mantra.MFS100.Agent.Extensions;
using Microsoft.Win32;
using System;
using System.Threading;
using System.Windows.Forms;

namespace CloudVOffice.Attendance.Mantra.MFS100.Agent
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        private static AppTrayIconContext TrayIcon;
        [STAThread]
        static void Main()
        {
            //Check if running other instances of application for the same user
            String mutexName = "CloudVOffice.Attendance.Mantra.MFS100.Agent" + System.Security.Principal.WindowsIdentity.GetCurrent().User.AccountDomainSid;
            Boolean createdNew;

            Mutex mutex = new Mutex(true, mutexName, out createdNew);

            if (createdNew)
            {
                //SessionClose Handling
                SystemEvents.SessionEnding += new SessionEndingEventHandler(AppExit);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                TrayIcon = new AppTrayIconContext();
                Application.Run(TrayIcon);
                Application.ApplicationExit += new System.EventHandler(AppExit);
            }


        }
        static void AppExit(object sender, EventArgs e)
        {
            TrayIcon.GracefulExit();
        }



    }


    public class AppTrayIconContext : ApplicationContext
    {
        private NotifyIcon trayIcon;


        //TODO: Refactor this
        private bool _dialogActive;
        private bool _aboutActive;
        private bool _settingsActive;

        private MainWindow fStats;
        private AttendanceModule attendanceModule;
        public AppTrayIconContext()
        {
            //Initialize Objects


            // Check if Runs Hidden

            //Build Menu
            ContextMenu mnu = new ContextMenu();

            mnu.MenuItems.Add(new MenuItem("Admin", OpenStats));
            mnu.MenuItems.Add(new MenuItem("Set Gateway Url", OpenStats));
            mnu.MenuItems.Add(new MenuItem("Record Attendance", OpenStats));
            mnu.MenuItems.Add(new MenuItem("About", About));
            //if (!AppSettings.HideMenuExit)
            //    mnu.MenuItems.Add(new MenuItem(ResFiles.GlobalRes.traymenu_Exit, Exit));




            trayIcon = new NotifyIcon()
            {
                Icon = new System.Drawing.Icon(@"C:\Users\krush\Downloads\machine.ico"),
                ContextMenu = mnu,
                Visible = true
            };

            trayIcon.DoubleClick += new System.EventHandler(OpenStats);
            AppDomain.CurrentDomain.ProcessExit += new System.EventHandler(Exit);

            attendanceModule = AttendanceModule.GetInstance;
            attendanceModule.TransType = "Validate";
            attendanceModule.OnMFS100Attached();

            attendanceModule.StartCapturing();



        }

        private bool setDBConfig()
        {
            return true;
        }
        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            GracefulExit();
        }

        void About(object sender, EventArgs e)
        {
            if (!_aboutActive)
            {
                //using (FormAbout fAbout = new FormAbout())
                //{
                //	_aboutActive = true;

                //	fAbout.ShowDialog();
                //	_aboutActive = false;
                //};
            }
        }
        public void GracefulExit()
        {
            trayIcon.Visible = false;
            //appMon.EndSession();
            //DBDumper.Stop();
            Application.Exit();
        }


        void OpenStats(Object sender, EventArgs e)
        {
            if (!_dialogActive)
            {
                fStats = new MainWindow();
                _dialogActive = true;
                fStats.ShowDialog();
                fStats.Dispose();
                _dialogActive = false;
            }
            else
            {
                fStats.Restore();
            }
        }
    }
}
