using System;

namespace DesktopMonitoringSystem.Models
{
    public class UserTokenModel
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expiration { get; set; }

    }
}
