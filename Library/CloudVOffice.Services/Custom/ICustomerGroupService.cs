using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Custom;
using CloudVOffice.Data.DTO.Custom;

namespace CloudVOffice.Services.Custom
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
