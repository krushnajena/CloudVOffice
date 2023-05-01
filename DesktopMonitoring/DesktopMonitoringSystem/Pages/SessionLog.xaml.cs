
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
        private void LoadLineChartData(LoginSessionModel loginSessionModel)
        {

            List<KeyValuePair<string, double>> keys = new List<KeyValuePair<string, double>>();
            for (int i = 0; i < loginSessionModel.data.Count; i++)
            {
                bool check = false;
                DateTime dt = DateTime.Parse( loginSessionModel.data[i].LoginDateTime.ToString()).Date;
                for (int j = 0; j < keys.Count; j++)
                {
                    if (keys[j].Key == dt.Date.ToString("dd-MM-yyyy"))
                    {
                        check = true;
                    }
                }


                if (check == false)
                {
                    if (loginSessionModel.data[i].Duration != null)
                    {
                        TimeSpan t1 = TimeSpan.Parse(loginSessionModel.data[i].Duration);
                        for (int k = 1; k < loginSessionModel.data.Count; k++)
                        {
                            if (DateTime.Parse(loginSessionModel.data[k].LoginDateTime.ToString()).Date == dt.Date)
                            {
                                if (loginSessionModel.data[k].Duration != null)
                                {
                                    TimeSpan t2 = TimeSpan.Parse(loginSessionModel.data[k].Duration);
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
        private void LoadWordDeurationChartData(LoginSessionModel loginSessionModel)
        {

            List<KeyValuePair<string, double>> keys = new List<KeyValuePair<string, double>>();
            for (int i = 0; i < loginSessionModel.data.Count; i++)
            {
                bool check = false;
                DateTime dt =DateTime.Parse( loginSessionModel.data[i].LoginDateTime.ToString()).Date;
                for (int j = 0; j < keys.Count; j++)
                {
                    if (keys[j].Key.ToString() == dt.Date.ToString("dd-MM-yyyy"))
                    {
                        check = true;
                    }
                }


                if (check == false)
                {
                    if (loginSessionModel.data[i].IdelDuration != null && loginSessionModel.data[i].IdelDuration != "")
                    {
                        TimeSpan t1 = TimeSpan.Parse(loginSessionModel.data[i].IdelDuration);
                        for (int k = 1; k < loginSessionModel.data.Count; k++)
                        {
                            if (loginSessionModel.data[k].LoginDateTime.Date == dt.Date)
                            {
                                TimeSpan t2 = TimeSpan.Parse(loginSessionModel.data[k].IdelDuration);
                                t1 = t1.Add(t2);

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


        private void GetSessionLog()
        {

            var a = HttpClientRq.GetCall(ApiUrls.getSessionLog + "/10803");
            var X = a.Result.Content.ReadAsStringAsync()
                                                       .Result
                                                       //.Replace("\\", "")
                                                       //.Replace("\r\n", "'")
                                                       .Trim(new char[1] { '"' });
            var json = JsonConvert.DeserializeObject<LoginSessionModel>(X);

            dg_SessionLog.ItemsSource = json.data;
            LoadLineChartData(json);
            LoadWordDeurationChartData(json);
            // MessageBox.Show(json.data.Count.ToString());

        }



    }


}
