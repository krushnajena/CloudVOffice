using DesktopMonitoringSystem.Models;
using DesktopMonitoringSystem.Utils;
using Newtonsoft.Json;
using System.Windows.Controls;

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
            // GetPrinting();
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
