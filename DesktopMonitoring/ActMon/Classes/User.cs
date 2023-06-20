using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DesktopMonitoringSystem.Classes
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string ApplicantName { get; set; }


        public string Token { get; set; }
        public string RefreshToken { get; set; }

    }
    public class TokenModel {

        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string ClientName { get; set; }
        public string ClientId { get; set; }
    }
    public class NewRefreshToken
    {
        public string RefreshToken { get; set;}
        public string AccessToken { get; set; }
    }
}
