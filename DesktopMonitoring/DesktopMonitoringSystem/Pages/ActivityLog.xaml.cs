using DesktopMonitoringSystem.Classes;
using DesktopMonitoringSystem.Models;
using DesktopMonitoringSystem.Utils;
using Microsoft.Win32;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace DesktopMonitoringSystem.Pages
{
    /// <summary>
    /// Interaction logic for ActivityLog.xaml
    /// </summary>
    public partial class ActivityLog : Page
    {
        ActivityLogModel activityLogm;
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        VideoViewer vV = new VideoViewer();
        DispatcherTimer timer = new DispatcherTimer();
        string UserId = "";
        string UserName = "";
        public ActivityLog()
        {
           

            InitializeComponent();

           

            SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
            var a = connection.Query<User>("select * from User").FirstOrDefault();
            if (a != null)
            {
                UserId = a.UserId.ToString();
                UserName = a.ApplicantName;
                GetActivityLog();
            }


        }
        public ActivityLog(string uid, string uname)
        {
            InitializeComponent();
            UserId = uid;
            UserName = uname;
            GetActivityLog();

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

        private void LoadWebColumChartData(ActivityLogModel activityLogModel)
        {

            List<KeyValuePair<string, double>> keys = new List<KeyValuePair<string, double>>();
            for (int i = 0; i < activityLogModel.data.Count; i++)
            {
                if (activityLogModel.data[i].ProcessOrUrl.ToLower().Contains("chrome"))
                {
                    bool check = false;
                    string dt = "";
                    if (activityLogModel.data[i].ProcessOrUrl.ToLower().Contains("chrome"))
                    {
                        dt = activityLogModel.data[i].AppOrWebPageName;
                    }
                    else
                    {
                        dt = activityLogModel.data[i].ProcessOrUrl;

                    }

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
                    
            }


            cc_webactivity.ItemsSource = keys;
            cc_webactivity.XBindingPath = "Key";
            cc_webactivity.YBindingPath = "Value";
            // columnChart.Series.Add(cc_activity);

            //TimeSpan t1 = TimeSpan.Parse("23:30");

            //  ((ColumnSeries)mcChart.Series[0]).ItemsSource = keys;
        }

        private void GetActivityLog()
        {
          
                var a = HttpClientRq.GetCall(ApiUrls.getActivityLog + "/" + UserId);
                var X = a.Result.Content.ReadAsStringAsync()
                                                           .Result
                                                           //.Replace("\\", "")
                                                           //.Replace("\r\n", "'")
                                                           .Trim(new char[1] { '"' });
                var json = JsonConvert.DeserializeObject<ActivityLogModel>(X);
                activityLogm = json;
                if (json != null)
                {
                    dg_ActivityLog.ItemsSource = json.data;
                    LoadColumChartData(json);
                    LoadWebColumChartData(json);
                    this.DataContext = vV;
                }
            
          
          
            // MessageBox.Show(json.data.Count.ToString());

        }

        private void dg_ActivityLog_SelectionChanged(object sender, Syncfusion.UI.Xaml.Grid.GridSelectionChangedEventArgs e)
        {

            List<ImageSource> images = new List<ImageSource>();

            //Create a new bitmap to assign our image to
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.CacheOption = BitmapCacheOption.None;
            bitmap.UriSource = new Uri("https://images.pexels.com/photos/268533/pexels-photo-268533.jpeg?cs=srgb&dl=pexels-pixabay-268533.jpg&fm=jpg", UriKind.Absolute);
            bitmap.EndInit();

            images.Add(bitmap);
            bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.CacheOption = BitmapCacheOption.None;
            bitmap.UriSource = new Uri("https://thumbs.dreamstime.com/b/environment-earth-day-hands-trees-growing-seedlings-bokeh-green-background-female-hand-holding-tree-nature-field-gra-130247647.jpg", UriKind.Absolute);
            bitmap.EndInit();

            images.Add(bitmap);


            images.Add(bitmap);
            bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.CacheOption = BitmapCacheOption.None;
            bitmap.UriSource = new Uri("https://images.pexels.com/photos/268533/pexels-photo-268533.jpeg?cs=srgb&dl=pexels-pixabay-268533.jpg", UriKind.Absolute);
            bitmap.EndInit();

            images.Add(bitmap);
            //Create a new bitmap to assign our image to
             bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.CacheOption = BitmapCacheOption.None;
            bitmap.UriSource = new Uri("https://images.pexels.com/photos/268533/pexels-photo-268533.jpeg?cs=srgb&dl=pexels-pixabay-268533.jpg&fm=jpg", UriKind.Absolute);
            bitmap.EndInit();

            images.Add(bitmap);
            bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.CacheOption = BitmapCacheOption.None;
            bitmap.UriSource = new Uri("https://thumbs.dreamstime.com/b/environment-earth-day-hands-trees-growing-seedlings-bokeh-green-background-female-hand-holding-tree-nature-field-gra-130247647.jpg", UriKind.Absolute);
            bitmap.EndInit();

            images.Add(bitmap);


            images.Add(bitmap);
            bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.CacheOption = BitmapCacheOption.None;
            bitmap.UriSource = new Uri("https://images.pexels.com/photos/268533/pexels-photo-268533.jpeg?cs=srgb&dl=pexels-pixabay-268533.jpg", UriKind.Absolute);
            bitmap.EndInit();

            images.Add(bitmap);

            //Create a new bitmap to assign our image to
             bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.CacheOption = BitmapCacheOption.None;
            bitmap.UriSource = new Uri("https://images.pexels.com/photos/268533/pexels-photo-268533.jpeg?cs=srgb&dl=pexels-pixabay-268533.jpg&fm=jpg", UriKind.Absolute);
            bitmap.EndInit();

            images.Add(bitmap);
            bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.CacheOption = BitmapCacheOption.None;
            bitmap.UriSource = new Uri("https://thumbs.dreamstime.com/b/environment-earth-day-hands-trees-growing-seedlings-bokeh-green-background-female-hand-holding-tree-nature-field-gra-130247647.jpg", UriKind.Absolute);
            bitmap.EndInit();

            images.Add(bitmap);


            images.Add(bitmap);
            bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.CacheOption = BitmapCacheOption.None;
            bitmap.UriSource = new Uri("https://images.pexels.com/photos/268533/pexels-photo-268533.jpeg?cs=srgb&dl=pexels-pixabay-268533.jpg", UriKind.Absolute);
            bitmap.EndInit();

            images.Add(bitmap);

            //Create a new bitmap to assign our image to
             bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.CacheOption = BitmapCacheOption.None;
            bitmap.UriSource = new Uri("https://images.pexels.com/photos/268533/pexels-photo-268533.jpeg?cs=srgb&dl=pexels-pixabay-268533.jpg&fm=jpg", UriKind.Absolute);
            bitmap.EndInit();

            images.Add(bitmap);
            bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.CacheOption = BitmapCacheOption.None;
            bitmap.UriSource = new Uri("https://thumbs.dreamstime.com/b/environment-earth-day-hands-trees-growing-seedlings-bokeh-green-background-female-hand-holding-tree-nature-field-gra-130247647.jpg", UriKind.Absolute);
            bitmap.EndInit();

            images.Add(bitmap);


            images.Add(bitmap);
            bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.CacheOption = BitmapCacheOption.None;
            bitmap.UriSource = new Uri("https://images.pexels.com/photos/268533/pexels-photo-268533.jpeg?cs=srgb&dl=pexels-pixabay-268533.jpg", UriKind.Absolute);
            bitmap.EndInit();

            images.Add(bitmap);
            //Create a new bitmap to assign our image to
           bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.CacheOption = BitmapCacheOption.None;
            bitmap.UriSource = new Uri("https://images.pexels.com/photos/268533/pexels-photo-268533.jpeg?cs=srgb&dl=pexels-pixabay-268533.jpg&fm=jpg", UriKind.Absolute);
            bitmap.EndInit();

            images.Add(bitmap);
            bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.CacheOption = BitmapCacheOption.None;
            bitmap.UriSource = new Uri("https://thumbs.dreamstime.com/b/environment-earth-day-hands-trees-growing-seedlings-bokeh-green-background-female-hand-holding-tree-nature-field-gra-130247647.jpg", UriKind.Absolute);
            bitmap.EndInit();

            images.Add(bitmap);


            images.Add(bitmap);
            bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.CacheOption = BitmapCacheOption.None;
            bitmap.UriSource = new Uri("https://images.pexels.com/photos/268533/pexels-photo-268533.jpeg?cs=srgb&dl=pexels-pixabay-268533.jpg", UriKind.Absolute);
            bitmap.EndInit();

            images.Add(bitmap);

            vV.imagesArray = images;
            timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1f / 120f) };
            timer.Tick += TimerTick;
            timer.Start();

        }
        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            vV.NextFrame();
        }

    }

    public class VideoViewer : INotifyPropertyChanged
    {
        private ImageSource image;
        private List<ImageSource> imageLocs = new List<ImageSource>();
        private int imageIndex = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        public ImageSource imageSource
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                OnPropertyChanged("imageSource");
            }
        }

        public List<ImageSource> imagesArray
        {
            get
            {
                return imageLocs;
            }
            set
            {
                imageLocs = value;
                OnPropertyChanged("imagesArray");
            }
        }

        public void NextFrame()
        {
            //If not on first or last frame
            if (imageIndex < (imageLocs.Count - 1))
            {
                imageIndex += 1;
                imageSource = imagesArray[imageIndex];
                OnPropertyChanged("imageSource");
            }
            else if (imageIndex == (imageLocs.Count - 1))
            {
                imageIndex = 0;
                imageSource = imagesArray[imageIndex];
                OnPropertyChanged("imageSource");
            }
        }

        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
