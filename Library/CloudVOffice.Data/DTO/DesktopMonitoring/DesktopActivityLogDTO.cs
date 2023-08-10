namespace CloudVOffice.Data.DTO.DesktopMonitoring
{
    public class DesktopActivityLogDTO
    {
        public Int64? DesktopActivityLogId { get; set; }
        public Int64 EmployeeId { get; set; }
        public string? LogType { get; set; }
        public Int64? DesktopLoginId { get; set; }
        public DateTime? LogDateTime { get; set; }
        public string? ComputerName { get; set; }
        public string? ProcessOrUrl { get; set; }
        public string? AppOrWebPageName { get; set; }
        public string? TypeOfApp { get; set; }
        public DateTime? SyncedOn { get; set; }


        public string? Action { get; set; }
        public string? Source { get; set; }
        public string? Folder { get; set; }
        public string? FileName { get; set; }

        public string? PrinterName { get; set; }
        public DateTime? Todatetime { get; set; }



        public Int64 CreatedBy { get; set; }
    }
}
