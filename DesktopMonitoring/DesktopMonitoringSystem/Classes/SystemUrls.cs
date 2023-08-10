using SQLite;


namespace DesktopMonitoringSystem.Classes
{
    public class SystemUrls
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string GateWayUrl { get; set; }

    }
}
