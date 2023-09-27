using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.HR.Master;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudVOffice.Core.Domain.Recruitment
{
    public class JobOpening : IAuditEntity, ISoftDeletedEntity
    {

        public int JobOpeningId { get; set; }
        public int JobOpType { get; set; }//1=OffSore,2=Onsore
        public int? ClientID { get; set; }
        public Int64? ContactId { get; set; }
        public Int64 HiringManagerId { get; set; } // Employee
        public string JobTitle { get; set; }

        public DateTime? DateOpened { get; set; }
        public DateTime? TargetDate { get; set; }
        public string JobType { get; set; }
        public string WorkExperience { get; set; }
        

        public string? City { get; set; }
        public double? RevenuePerPosition { get; set; }
        public int? NumberofPositions { get; set; }
        public double? ExpectedRevenue { get; set; }
        public double? ActualRevenue { get; set; }

		public int Status { get; set; }
        public string? JobDescription { get; set; }
        public string? Requirements { get; set; }
        public string? Benefits { get; set; }
        public bool PublishOnWebsite { get; set; }
		

        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

		[ForeignKey("HiringManagerId")]
		public Employee Employee { get; set; }

		[ForeignKey("ContactId")]
		public RecruitClientContact RecruitClientContact { get; set; }

        [ForeignKey("ClientID")]
        public RecruitClient RecruitClient { get; set; }



    }
}
