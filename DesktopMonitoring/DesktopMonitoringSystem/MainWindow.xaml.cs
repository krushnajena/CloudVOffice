using DesktopMonitoringSystem.Classes;
using DesktopMonitoringSystem.Models;
using DesktopMonitoringSystem.Utils;
using Microsoft.Win32;
using Newtonsoft.Json;
using SQLite;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Windows;

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
                if (txt_UserName.Text == "" && txt_password.Password == "")
                {

                }
                else
                {
                    LoginModel login = new LoginModel();
                    login.Email = txt_UserName.Text;
                    login.Password = txt_password.Password;
                    login.ClientName = (string)Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion").GetValue("ProductName");
                    login.ClientId = System.Environment.GetEnvironmentVariable("COMPUTERNAME");

                    var a = await HttpClientRq.PostRequest(ApiUrls.postLogin, JsonConvert.SerializeObject(login), true);

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
                            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                            reg.SetValue("ACTMONA", @"C:\Program Files (x86)\CloudSat Pvt Ltd\Csat Desk Monitering\ActMon\ActMon.exe");
                            MessageBox.Show("Please Restart The System For Activate Services.", "Restart Required");
                            this.Close();
                            //DashBoardWindow dashBoardWindow = new DashBoardWindow();
                            //dashBoardWindow.Show();


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
