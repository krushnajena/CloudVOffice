using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace DesktopMonitoringSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            String mutexName = "Dms" + System.Security.Principal.WindowsIdentity.GetCurrent().User.AccountDomainSid;
            Boolean createdNew;

            Mutex mutex = new Mutex(true, mutexName, out createdNew);

            if (createdNew)
            {
                
            }
            base.OnStartup(e);

            new DashBoardWindow();
        }
    }
}
