namespace CloudVOffice.Data.DTO.DesktopMonitoring
{
    public class RestrictedApplicationDTO
    {
        public Int64? RestrictedApplicationId { get; set; }
        public string RestrictedApplicationName { get; set; }
        public int? DepartmentId { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
