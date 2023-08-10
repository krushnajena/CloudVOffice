namespace CloudVOffice.Data.DTO.Recruitment
{
    public class StaffingPlanDTO
    {
        public int? StaffingPlanId { get; set; }
        public string PlanName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? DepartmentId { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
