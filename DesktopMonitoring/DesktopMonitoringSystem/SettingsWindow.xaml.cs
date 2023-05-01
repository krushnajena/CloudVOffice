using DesktopMonitoringSystem.Classes;
using SQLite;
using System;
using System.Collections.Generic;
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

using Microsoft.Data.Sqlite;

namespace DesktopMonitoringSystem
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            SystemUrls systemU= new SystemUrls();
            systemU.ClientUrl = txt_GatewayUrl.Text;
            systemU.GateWayUrl = txt_GatewayUrl.Text;
            SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
           var a= connection.Query<SystemUrls>("select * from SystemUrls").FirstOrDefault();
            if (a != null)
            {
                a.GateWayUrl = txt_GatewayUrl.Text;
                a.ClientUrl = txt_GatewayUrl.Text;
                connection.Update(a);
                MessageBox.Show("Setting Overrided Successfully", "DMS",MessageBoxButton.OK,MessageBoxImage.Information);
                this.Close();
            }
            else
            {
                connection.Insert(systemU);
                MessageBox.Show("Setting Saved Succefully", "DMS", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }

           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btn_back_to_login_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
