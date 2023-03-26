using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core
{
    public interface ISoftDeletedEntity
    {
        bool Deleted { get; set; }
    }
}
