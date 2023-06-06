using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Customer;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Customer;
using CloudVOffice.Data.DTO.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Customer
{
    public interface ICustomerGroupService
    {
        public MessageEnum CustomerGroupCreate(CustomerGroupDTO customerGroupDTO);
        public List<CustomerGroup> GetCustomerGroups();
        public CustomerGroup GetCustomerGroupByCustomerGroupId(int customerGroupId);
        public CustomerGroup GetCustomerGroupByCustomerGroupName(string CustomerGroupName);
        public MessageEnum CustomerGroupUpdate(CustomerGroupDTO customerGroupDTO);
        public MessageEnum CustomerGroupDelete(int customerGroupId, Int64 DeletedBy);
    }
}
