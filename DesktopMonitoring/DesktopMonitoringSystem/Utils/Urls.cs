using DesktopMonitoringSystem.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopMonitoringSystem.Utils
{
    public class ApiUrls
    {
        public string _gateWayBaseUrl { get; set; } = "";
        public string _clientBaseUrl { get; set; } = "";
        public ApiUrls()
        {
            SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
            var a = connection.Query<SystemUrls>("select * from SystemUrls").FirstOrDefault();
            if (a != null)
            {
                _gateWayBaseUrl = a.GateWayUrl;
                _clientBaseUrl = a.ClientUrl;
            }
        }
      
        public static string getGatewayUrl()
        {
            SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
            var a = connection.Query<SystemUrls>("select * from SystemUrls").FirstOrDefault();
            if (a != null)
            {
                return a.GateWayUrl;
              
            }
            else return "";
        }

        public static string getClientUrl()
        {
            SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
            var a = connection.Query<SystemUrls>("select * from SystemUrls").FirstOrDefault();
            if (a != null)
            {
                return a.ClientUrl;

            }
            else return "";
        }

        public static string postLogin = getGatewayUrl() + "/api/Login/Auth";
        public static string getSessionLog     = getGatewayUrl()+ "/api/DesktopLogin/GeteLoginSessionsByUserId";
        public static string getActivityLog    = getGatewayUrl() + "/api/DMSActivityLog/GetAcivityLogsByUserId";
        public static string getFileOperation  = getGatewayUrl() + "/api/DMSActivityLog/GetFileLogsByUserId";
        public static string getPrinting      = getGatewayUrl() + "/api/DMSActivityLog/GetPrintLogsByUserId";
        public static string getKeyStroke = getGatewayUrl() + "/api/DMSActivityLog/GetKeyStrokLogsByUserId";

        public static string imageUpload = getClientUrl() + "/api/DMSActivityLog/GetKeyStrokLogsByUserId";
    }
}
