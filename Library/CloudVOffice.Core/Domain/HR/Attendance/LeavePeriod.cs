using System.ComponentModel.DataAnnotations.Schema;

namespace CloudVOffice.Core.Domain.HR.Attendance
{
    public class LeavePeriod : IAuditEntity, ISoftDeletedEntity
    {
        public int LeavePeriodId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
		[NotMapped]
		public string LeavePeriodName {

			get
			{
				 return FromDate.ToString("dd-MMM-yyyy") + "-" + ToDate.ToString("dd-MMM-yyyy"); 

			}
		}

        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
       

    }
}
