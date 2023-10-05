using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Custom;
using CloudVOffice.Data.DTO.Custom;

namespace CloudVOffice.Services.Custom
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
