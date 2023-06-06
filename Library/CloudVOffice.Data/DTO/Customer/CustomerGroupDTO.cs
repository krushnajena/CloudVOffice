using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Customer
{
    public class CustomerGroupDTO
    {
        public int? CustomerGroupId { get; set; }
        public string CustomerGroupName { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
