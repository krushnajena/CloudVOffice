using CloudVOffice.Data.DTO.DesktopMonitoring;
using DesktopMonitoringSystem.Classes;
using DesktopMonitoringSystem.Models;
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
        private void LoadColumChartData(ActivityLogModel activityLogModel)
        {

            List<KeyValuePair<string, double>> keys = new List<KeyValuePair<string, double>>();
            for (int i = 0; i < activityLogModel.data.Count; i++)
            {
                bool check = false;
                string dt = "";

                dt = activityLogModel.data[i].ProcessOrUrl;



                for (int j = 0; j < keys.Count; j++)
                {
                    if (keys[j].Key == dt)
                    {
                        check = true;
                    }
                }


                if (check == false)
                {
                    if (activityLogModel.data[i].Todatetime != null)
                    {
                        DateTime? fromtime = activityLogModel.data[i].LogDateTime;
                        DateTime? totime = activityLogModel.data[i].Todatetime;
                        var hours = DateTime.Parse(totime.ToString()).Subtract(DateTime.Parse(fromtime.ToString()));

                        for (int k = 1; k < activityLogModel.data.Count; k++)
                        {
                            if (activityLogModel.data[k].ProcessOrUrl == dt)
                            {
                                DateTime? afromtime = activityLogModel.data[k].LogDateTime;
                                DateTime? atotime = activityLogModel.data[k].Todatetime;
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

        private void GetActivityLog()
        {
          

            var a = HttpClientRq.GetCall(ApiUrls.getActivityLog);
            var X = a.Result.Content.ReadAsStringAsync()
                                                       .Result
                                                       //.Replace("\\", "")
                                                       //.Replace("\r\n", "'")
                                                       .Trim(new char[1] { '"' });
            var json = JsonConvert.DeserializeObject<ActivityLogModel>(X);
           
            if (json != null)
            {
            
                LoadColumChartData(json);
                
            }



            // MessageBox.Show(json.data.Count.ToString());

        }



    }





}
