using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.HR
{
    public class HRSettings : IAuditEntity, ISoftDeletedEntity
    {
        public int HRSettingsId { get; set; }
        public double? StandardWorkingHours { get; set; }
        public double? BreakHours { get; set; }
        public int? RetirementAge { get; set; }
        public bool SendBirthdaysReminder { get; set; }
        public bool SendWorkAnniversariesReminder { get; set; }
        public bool SendInterviewReminder { get; set; }
        public bool SendInterviewFeedbackReminder { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

    }
}
