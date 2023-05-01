using DesktopMonitoringSystem.Classes;
using Microsoft.Data.Sqlite;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DesktopMonitoringSystem
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        public SplashScreen()
        {
            InitializeComponent();
            CheckDb();
        }
        private void CheckDb()
        {
            if (!Directory.Exists(DbContext.floderPath))
            {
                Directory.CreateDirectory(DbContext.floderPath);
                
            }
            SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
            connection.CreateTable<User>();
            //connection.CreateTable<UserLoginDetails>();
            connection.CreateTable<SystemUrls>();
            connection.CreateTable<DmsSessionLog>();
            connection.CreateTable<DMSActivityLog>();

            connection.CreateTable<DMSScreenShotLog>();

            var a = connection.Query<User>("select * from User").FirstOrDefault();
            if(a != null)
            {
                if(a.UserId != null)
                {
                    DashBoardWindow mainWindow = new DashBoardWindow();
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
           
        }
    }
}
