using System;
using System.IO;

namespace ActMon.Classes
{
    public class DbContext
    {
        public static string dbName = "dms.db";
        public static string floderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/DMS";
        public static string databasePath = Path.Combine(floderPath, dbName);
    }
}
