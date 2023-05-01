using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesktopMonitoringSystem.Classes
{
    public class DbContext
    {
        public static string dbName = "dms.db";
        public static string floderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+"/DMS";
        public static string databasePath = Path.Combine(floderPath, dbName);
    }
}
