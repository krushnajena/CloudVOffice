namespace CloudVOffice.Data.DTO.Recruitment
{
    public class StaffingPlanDetailsDTO
    {
        public int? StaffingPlanDetailsId { get; set; }
        public int DesignationId { get; set; }
        public int NoOfVacancies { get; set; }
        public double? EstimatedCostPerPosition { get; set; }

        public Int64 CreatedBy { get; set; }
    }
}
