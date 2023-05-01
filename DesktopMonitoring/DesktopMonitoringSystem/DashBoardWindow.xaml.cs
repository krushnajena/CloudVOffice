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

namespace DesktopMonitoringSystem
{
    /// <summary>
    /// Interaction logic for DashBoardWindow.xaml
    /// </summary>
    public partial class DashBoardWindow : Window
    {
        public DashBoardWindow()
        {
            InitializeComponent();
          
            lbl_tittle.Text = "Dashboard";
            PagesNavigation.Navigate(new System.Uri("Pages/Home.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void dashbord_Click(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            btn_home.Background = (Brush)bc.ConvertFrom("#594ad8");
            btn_sessionlog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_activitylog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_fileoperaionlog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_keystokelog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_printlog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            lbl_tittle.Text = "Dashboard";

            PagesNavigation.Navigate(new System.Uri("Pages/Home.xaml", UriKind.RelativeOrAbsolute));
        }
        private void SessionLog_Click(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            btn_home.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_sessionlog.Background = (Brush)bc.ConvertFrom("#594ad8");
            btn_activitylog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_fileoperaionlog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_keystokelog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_printlog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            lbl_tittle.Text = "Session Log";
            PagesNavigation.Navigate(new System.Uri("Pages/SessionLog.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ActivityLog_Click(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            btn_home.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_sessionlog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_activitylog.Background = (Brush)bc.ConvertFrom("#594ad8");
            btn_fileoperaionlog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_keystokelog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_printlog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            lbl_tittle.Text = "Activity Log";

            PagesNavigation.Navigate(new System.Uri("Pages/ActivityLog.xaml?uid=5455&&uname=KJ", UriKind.RelativeOrAbsolute));
        }
        private void FileOperations_Click(object sender, RoutedEventArgs e)
        {

            var bc = new BrushConverter();
            btn_home.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_sessionlog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_activitylog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_fileoperaionlog.Background = (Brush)bc.ConvertFrom("#594ad8");
            btn_keystokelog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_printlog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            lbl_tittle.Text = "File Operation Log";

            PagesNavigation.Navigate(new System.Uri("Pages/FileOperations.xaml", UriKind.RelativeOrAbsolute));
        }
        private void Printing_Click(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            btn_home.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_sessionlog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_activitylog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_fileoperaionlog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_keystokelog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_printlog.Background = (Brush)bc.ConvertFrom("#594ad8");
            lbl_tittle.Text = "Printing Log";
            PagesNavigation.Navigate(new System.Uri("Pages/Printing.xaml", UriKind.RelativeOrAbsolute));
        }
        private void KeyStrokes_Click(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            btn_home.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_sessionlog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_activitylog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_fileoperaionlog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            btn_keystokelog.Background = (Brush)bc.ConvertFrom("#594ad8");
            btn_printlog.Background = (Brush)bc.ConvertFrom("#FF0C20A5");
            lbl_tittle.Text = "Keystroke Log";
            PagesNavigation.Navigate(new System.Uri("Pages/KeyStroke.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btn_Logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please Contact System Admin To Stop Monitering");
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
