using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace DesktopMonitoringSystem.Classes
{
    public class SystemUrls
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string GateWayUrl { get; set; }
        public string ClientUrl { get; set; }
    }
}
