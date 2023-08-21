using DesktopMonitoringSystem.Models;
using DesktopMonitoringSystem.Utils;

using Newtonsoft.Json;
using System.Windows.Controls;

namespace DesktopMonitoringSystem.Pages
{
    /// <summary>
    /// Interaction logic for KeyStroke.xaml
    /// </summary>
    public partial class KeyStroke : Page
    {
        public KeyStroke()
        {
            InitializeComponent();
            // GetKeyStroke();

        }

        private void GetKeyStroke()
        {
            var a = HttpClientRq.GetCall(ApiUrls.getKeyStroke + "/10803");
            var X = a.Result.Content.ReadAsStringAsync()
                                                       .Result
            //.Replace("\\", "")
            //.Replace("\r\n", "'")
                                                       .Trim(new char[1] { '"' });
            var json = JsonConvert.DeserializeObject<KeyStrokeModel>(X);

            dg_KeyStroke.ItemsSource = json.data;
        }
    }
}
