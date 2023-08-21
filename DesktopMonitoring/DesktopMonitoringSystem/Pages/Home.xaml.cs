using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using DesktopMonitoringSystem.Classes;
using DesktopMonitoringSystem.Utils;

using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;


namespace DesktopMonitoringSystem.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {

        string UserId = "";
        string UserName = "";
        //  private ApplicationView _idleCtl;
        public Home()
        {

            // _appMon = AppMonitor;


            InitializeComponent();


            SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
            var a = connection.Query<User>("select * from User").FirstOrDefault();

            if (a != null)
            {
                GetActivityLog();
                UserId = a.UserId.ToString();
                UserName = a.ApplicantName;
                //  
            }
        }
        private void LoadColumChartData(List<DesktopActivityLog> activityLogModel)
        {

            List<KeyValuePair<string, double>> keys = new List<KeyValuePair<string, double>>();
            for (int i = 0; i < activityLogModel.Count; i++)
            {
                bool check = false;
                string dt = "";

                dt = activityLogModel[i].ProcessOrUrl;



                for (int j = 0; j < keys.Count; j++)
                {
                    if (keys[j].Key == dt)
                    {
                        check = true;
                    }
                }


                if (check == false)
                {
                    if (activityLogModel[i].Todatetime != null)
                    {
                        DateTime? fromtime = activityLogModel[i].LogDateTime;
                        DateTime? totime = activityLogModel[i].Todatetime;
                        var hours = DateTime.Parse(totime.ToString()).Subtract(DateTime.Parse(fromtime.ToString()));

                        for (int k = 1; k < activityLogModel.Count; k++)
                        {
                            if (activityLogModel[k].ProcessOrUrl == dt)
                            {
                                DateTime? afromtime = activityLogModel[k].LogDateTime;
                                DateTime? atotime = activityLogModel[k].Todatetime;
                                var ahours = DateTime.Parse(atotime.ToString()).Subtract(DateTime.Parse(afromtime.ToString()));

                                // TimeSpan t2 = TimeSpan.Parse(activityLogModel.data[k].Duration);
                                hours = hours.Add(ahours);

                            }

                        }
                        keys.Add(new KeyValuePair<string, double>(dt, hours.TotalHours));

                    }
                    else
                    {
                        keys.Add(new KeyValuePair<string, double>(dt, 0));
                    }
                }
            }


            cc_activity.ItemsSource = keys;
            cc_activity.XBindingPath = "Key";
            cc_activity.YBindingPath = "Value";
            // columnChart.Series.Add(cc_activity);

            //TimeSpan t1 = TimeSpan.Parse("23:30");

            //  ((ColumnSeries)mcChart.Series[0]).ItemsSource = keys;
        }

        private async void GetActivityLog()
        {

            DesktopLoginFilterDTO desktopLoginFilterDTO = new DesktopLoginFilterDTO { FromDate = DateTime.Today.AddDays(-30), ToDate = DateTime.Today.AddDays(1) };
            var a = await HttpClientRq.PostRequest(ApiUrls.getActivityLog, JsonConvert.SerializeObject(desktopLoginFilterDTO));


            var X = a.Content.ReadAsStringAsync()
                                                       .Result
                                                       //.Replace("\\", "")
                                                       //.Replace("\r\n", "'")
                                                       .Trim(new char[1] { '"' });
            var json = JsonConvert.DeserializeObject<List<DesktopActivityLog>>(X);
            if (json != null)
            {

                LoadColumChartData(json);

            }



            // MessageBox.Show(json.data.Count.ToString());

        }



    }





}
