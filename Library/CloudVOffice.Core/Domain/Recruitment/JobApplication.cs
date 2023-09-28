using CloudVOffice.Core.Domain.HR.Emp;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudVOffice.Core.Domain.Recruitment
{
    public class JobApplication : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 JobApplicationId { get; set; }
        public int JobId { get; set; }
        public Int64 CandidateId { get; set; }
        public Int64 TagId { get; set; }
        public DateTime Created { get; set; }
        public int CurrentStatus { get; set; }
   
        public string ApplicationViewToken { get; set; }
		public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("CandidateId")]
        public Candidate Candidate{ get; set; }

        [ForeignKey("JobId")]
        public JobOpening JobOpening { get; set; }


        [ForeignKey("TagId")]
        public Employee Employee { get; set; }

    }
}
