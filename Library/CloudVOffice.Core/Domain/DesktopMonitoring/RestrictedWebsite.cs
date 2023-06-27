using CloudVOffice.Core.Domain.HR.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.DesktopMonitoring
{
    public class RestrictedWebsite : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 RestrictedWebsiteId { get; set; }
        public string RestrictedWebsiteName { get; set; }
        public int? DepartmentId { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }
    }
}
