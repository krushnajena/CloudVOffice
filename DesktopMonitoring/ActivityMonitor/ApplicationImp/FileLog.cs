using System;
using System.Collections.ObjectModel;

namespace ActivityMonitor.ApplicationImp
{
    public class FileLog : ObservableCollection<FileLog>
    {
        public DateTime LogDateTime { get; set; }
        public string Action { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public bool IsSynced { get; set; } = false;

        public void UpdateSyncTime()
        {

            IsSynced = true;
        }
    }
}
