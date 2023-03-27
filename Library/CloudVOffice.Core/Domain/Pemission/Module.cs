using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Pemission
{
    public class Module:BaseEntity,IAuditEntity, ISoftDeletedEntity
    {
        public string ModuleName { get; set; }

        public int? Parent { get; set; }
        public bool IsGroup { get; set; }
        public string Url { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        public ICollection<Module> Children { get; set; }
    }
}
