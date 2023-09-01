using System.ComponentModel.DataAnnotations.Schema;

namespace CloudVOffice.Core.Domain.Recruitment
{
    public class JobApplication : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 JobApplicationId { get; set; }
        public int JobId { get; set; }
        public string ApplicantName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNo { get; set; }
        public int? JobApplicationSourceId { get; set; }
        public string? TagDescription { get; set; }
        public string? CV { get; set; }
        public double? SalaryExpectation { get; set; }
        public double? SalaryExpectationLowerRange { get; set; }
        public int Status { get; set; } = 0; //0=Submitted, 1= Interview In-Progress,2=ShortListed,3=Rejected, 4= Offer Letter Sent , 5= Offer Accepted,6 = Offer Rejected
        public int? RejectedInInterviewRoundId { get; set; }    
       public string? OfferRejecttionReason { get; set; }
        public DateTime? OfferRejectedOn { get; set; }
		public DateTime? OfferAccepteddOn { get; set; }

		public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("JobApplicationSourceId")]
        public JobApplicationSource JobApplicationSource { get; set; }

        [ForeignKey("JobId")]
        public JobOpening JobOpening { get; set; }

    }
}
