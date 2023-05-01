using DesktopMonitoringSystem.Models;
using DesktopMonitoringSystem.Utils;
using Newtonsoft.Json;
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

namespace DesktopMonitoringSystem.Pages
{
    /// <summary>
    /// Interaction logic for Printing.xaml
    /// </summary>
    public partial class Printing : Page
    {
        public Printing()
        {
            InitializeComponent();
            GetPrinting();
        }

        private void GetPrinting()
        {
            var a = HttpClientRq.GetCall(ApiUrls.getPrinting + "/10803");
            var X = a.Result.Content.ReadAsStringAsync()
                                                       .Result
                                                       //.Replace("\\", "")
                                                       //.Replace("\r\n", "'")
                                                       .Trim(new char[1] { '"' });
            var json = JsonConvert.DeserializeObject<PrintingModel>(X);

            dg_Printing.ItemsSource = json.data;

            // MessageBox.Show(json.data.Count.ToString());
        }
    }
    
}
