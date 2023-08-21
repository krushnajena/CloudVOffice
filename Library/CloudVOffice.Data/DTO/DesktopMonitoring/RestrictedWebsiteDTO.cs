namespace CloudVOffice.Data.DTO.DesktopMonitoring
{
    public class RestrictedWebsiteDTO
    {
        public Int64? RestrictedWebsiteId { get; set; }
        public string RestrictedWebsiteName { get; set; }
        public int? DepartmentId { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
