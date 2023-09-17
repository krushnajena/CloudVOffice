using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Recruitment
{
    public class JobOpeningDTO
    {
        public int? JobOpeningId { get; set; }
		public int JobOpType { get; set; }
		public int? ClientID { get; set; }
		public Int64? ContactId { get; set; }
		public Int64 HiringManagerId { get; set; } 
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
    }
}
