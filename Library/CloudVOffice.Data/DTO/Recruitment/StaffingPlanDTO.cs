using CloudVOffice.Data.DTO.Projects;

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
        public List<StaffingPlanDetailsDTO>? StaffingPlanDetails { get; set; }
        public string StaffingPlanDetailsString { get; set; }
    }

    public class StaffingPlanDetailsDTO
    {
        public int StaffingPlanId { get; set; }
        public int DesignationId { get; set; }
        public int NoOfVacancies { get; set; }
        public double? EstimatedCostPerPosition { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
