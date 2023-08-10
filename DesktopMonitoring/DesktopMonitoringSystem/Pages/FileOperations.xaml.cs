using DesktopMonitoringSystem.Models;
using DesktopMonitoringSystem.Utils;
using Newtonsoft.Json;
using System.Windows.Controls;

namespace DesktopMonitoringSystem.Pages
{
    /// <summary>
    /// Interaction logic for FileOperations.xaml
    /// </summary>
    public partial class FileOperations : Page
    {
        public FileOperations()
        {
            InitializeComponent();
            // GetFileOperations();

        }
        private void GetFileOperations()
        {

            var a = HttpClientRq.GetCall(ApiUrls.getFileOperation + "/10803");
            var X = a.Result.Content.ReadAsStringAsync()
                                                       .Result
                                                       //.Replace("\\", "")
                                                       //.Replace("\r\n", "'")
                                                       .Trim(new char[1] { '"' });
            var json = JsonConvert.DeserializeObject<FileOperationsModel>(X);

            dg_FileOperation.ItemsSource = json.data;

            // MessageBox.Show(json.data.Count.ToString());

        }
    }
}
