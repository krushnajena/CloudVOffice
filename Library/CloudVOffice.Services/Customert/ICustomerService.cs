using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Customert;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Customert;
using CloudVOffice.Data.DTO.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Customert
{
    public interface ICustomerService
    {
        public MessageEnum CustomerCreate(CustomerDTO customerDTO);
        public List<Customer> GetCustomers();
        public Customer GetCustomerByCustomerId(Int64 customerId);
        public Customer GetCustomerByCustomerName(string customerName);
        public MessageEnum CustomerUpdate(CustomerDTO customerDTO);
        public MessageEnum CustomerDelete(Int64 customerId, Int64 DeletedBy);
    }
}
