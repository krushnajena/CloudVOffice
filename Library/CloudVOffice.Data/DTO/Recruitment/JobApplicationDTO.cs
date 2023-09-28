using Microsoft.AspNetCore.Http;

namespace CloudVOffice.Data.DTO.Recruitment
{
    public class JobApplicationDTO
    {
        public Int64 JobApplicationId { get; set; }
        public int JobId { get; set; }
        public Int64 CandidateId { get; set; }
        public Int64 TagId { get; set; }
        public DateTime Created { get; set; }
        public int CurrentStatus { get; set; }


        public string ApplicationViewToken { get; set; }
        public Int64 CreatedBy { get; set; }
        public string Comment { get; set; }
        
    }

}
