namespace CloudVOffice.Data.DTO.Recruitment
{
    public class JobApplicationDTO
    {
        public Int64? JobApplicationId { get; set; }
        public int JobId { get; set; }
        public string ApplicantName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNo { get; set; }
        public int? JobApplicationSourceId { get; set; }
        public string? TagDescription { get; set; }
        public string? CV { get; set; }
        public double? SalaryExpectation { get; set; }
        public double? SalaryExpectationLowerRange { get; set; }

        public Int64 CreatedBy { get; set; }
    }
}
