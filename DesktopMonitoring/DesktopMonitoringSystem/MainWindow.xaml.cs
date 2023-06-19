using DesktopMonitoringSystem.Utils;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

using Newtonsoft.Json;
using System.Net;
using SQLite;
using DesktopMonitoringSystem.Classes;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.Win32;
using DesktopMonitoringSystem.Models;

namespace DesktopMonitoringSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial record LoginModel
    {
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Id")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }
        public string ClientName { get; set; }
        public string ClientId { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            if (ApiUrls.getGatewayUrl() != "")
            {
                if(txt_UserName.Text=="" && txt_password.Password == "")
                {

                }
                else
                {
                    LoginModel login = new LoginModel();
                    login.Email = txt_UserName.Text;
                    login.Password = txt_password.Password;
                    login.ClientName= (string)Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion").GetValue("ProductName");
                    login.ClientId = System.Environment.GetEnvironmentVariable("COMPUTERNAME");

                    var a = HttpClientRq.PostRequest(ApiUrls.postLogin, JsonConvert.SerializeObject(login)).Result;
                    if (a.StatusCode == HttpStatusCode.OK)
                    {
                        var X = a.Content.ReadAsStringAsync()
                                                              .Result
                                                              //.Replace("\\", "")
                                                              //.Replace("\r\n", "'")
                                                              .Trim(new char[1] { '"' });
                        var json = JsonConvert.DeserializeObject<UserTokenModel>(X);

                       

                        if (json != null)
                        {
                            User user = new User();
                            user.Token = json.Token.ToString();
                            user.RefreshToken = json.RefreshToken.ToString();
                       
                            SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
                            connection.Insert(user);

                            DashBoardWindow dashBoardWindow = new DashBoardWindow();
                            dashBoardWindow.Show();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Invalid User Name or Password");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name or Password");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please Set Application Urls");

                SettingsWindow settingsWindow = new SettingsWindow();
                settingsWindow.Show();
            }
            
        }

        private void btn_settings_Click(object sender, RoutedEventArgs e)
        {
          
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
        }
    }
}
