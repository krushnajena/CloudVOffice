
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using DesktopMonitoringSystem.Classes;
using DesktopMonitoringSystem.Models;
using DesktopMonitoringSystem.Utils;
using Newtonsoft.Json;
using Syncfusion.Themes.FluentDark.WPF;
using System;
using System.Collections.Generic;
using System.Windows.Controls;


namespace DesktopMonitoringSystem.Pages
{
    /// <summary>
    /// Interaction logic for SessionLog.xaml
    /// </summary>
    public partial class SessionLog : Page
    {

        public SessionLog()
        {
            InitializeComponent();
            GetSessionLog();

        }
        private void LoadLineChartData(List<DesktopLogin> loginSessionModel)
        {

            List<KeyValuePair<string, double>> keys = new List<KeyValuePair<string, double>>();
            for (int i = 0; i < loginSessionModel.Count; i++)
            {
                bool check = false;
                DateTime dt = DateTime.Parse( loginSessionModel[i].LoginDateTime.ToString()).Date;
                for (int j = 0; j < keys.Count; j++)
                {
                    if (keys[j].Key == dt.Date.ToString("dd-MM-yyyy"))
                    {
                        check = true;
                    }
                }


                if (check == false)
                {
                    if (loginSessionModel[i].Duration != null)
                    {
                        TimeSpan t1 = TimeSpan.Parse(loginSessionModel[i].Duration);
                        for (int k = 1; k < loginSessionModel.Count; k++)
                        {
                            if (DateTime.Parse(loginSessionModel[k].LoginDateTime.ToString()).Date == dt.Date)
                            {
                                if (loginSessionModel[k].Duration != null)
                                {
                                    TimeSpan t2 = TimeSpan.Parse(loginSessionModel[k].Duration);
                                    t1 = t1.Add(t2);
                                }
                                

                            }

                        }
                        keys.Add(new KeyValuePair<string, double>(dt.Date.ToString("dd-MM-yyyy"), t1.TotalHours));

                    }
                    else
                    {
                        keys.Add(new KeyValuePair<string, double>(dt.Date.ToString("dd-MM-yyyy"), 0));
                    }
                }
            }
            //TimeSpan t1 = TimeSpan.Parse("23:30");
            cb_sessionlog.ItemsSource = keys;
            cb_sessionlog.XBindingPath = "Key";
            cb_sessionlog.YBindingPath = "Value";
          
        }
        private void LoadWordDeurationChartData(List<DesktopLogin> loginSessionModel)
        {

            List<KeyValuePair<string, double>> keys = new List<KeyValuePair<string, double>>();
            for (int i = 0; i < loginSessionModel.Count; i++)
            {
                bool check = false;
                DateTime dt =DateTime.Parse( loginSessionModel[i].LoginDateTime.ToString()).Date;
                for (int j = 0; j < keys.Count; j++)
                {
                    if (keys[j].Key.ToString() == dt.Date.ToString("dd-MM-yyyy"))
                    {
                        check = true;
                    }
                }


                if (check == false)
                {
                    if (loginSessionModel[i].IdelTime != null)
                    {
                        TimeSpan t1 = TimeSpan.Parse(loginSessionModel[i].IdelTime.ToString());
                        for (int k = 1; k < loginSessionModel.Count; k++)
                        {
                            if (DateTime.Parse( loginSessionModel[k].LoginDateTime.ToString()).Date == dt.Date)
                            {
                                if (loginSessionModel[k].IdelTime != null)
                                {
                                    TimeSpan t2 = TimeSpan.Parse(loginSessionModel[k].IdelTime.ToString());
                                    t1 = t1.Add(t2);
                                }
                             

                            }

                        }
                        keys.Add(new KeyValuePair<string, double>(dt.Date.ToString("dd-MM-yyyy"), t1.TotalHours));

                    }
                    else
                    {
                        keys.Add(new KeyValuePair<string, double>(dt.Date.ToString("dd-MM-yyyy"), 0));
                    }
                }
            }
            //TimeSpan t1 = TimeSpan.Parse("23:30");

            cb_idealdurection.ItemsSource = keys;
            cb_idealdurection.XBindingPath = "Key";
            cb_idealdurection.YBindingPath = "Value";
        }


        private async void GetSessionLog()
        {
            DesktopLoginFilterDTO desktopLoginFilterDTO = new DesktopLoginFilterDTO { FromDate = DateTime.Today.AddDays(-30), ToDate = DateTime.Today.AddDays(1) };
            var a = await HttpClientRq.PostRequest(ApiUrls.getSessionLog, JsonConvert.SerializeObject(desktopLoginFilterDTO));

            
            var X = a.Content.ReadAsStringAsync()
                                                       .Result
                                                       //.Replace("\\", "")
                                                       //.Replace("\r\n", "'")
                                                       .Trim(new char[1] { '"' });
            var json = JsonConvert.DeserializeObject<List<DesktopLogin>>(X);

            dg_SessionLog.ItemsSource = json;
            LoadLineChartData(json);
            LoadWordDeurationChartData(json);
            // MessageBox.Show(json.data.Count.ToString());

        }



    }


}
