using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Customer;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Customer;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Customer
{
    public class CustomerGroupService : ICustomerGroupService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<CustomerGroup> _customerGroupRepo;
        public CustomerGroupService(ApplicationDBContext Context, ISqlRepository<CustomerGroup> customerGroupRepo)
        {

            _Context = Context;
            _customerGroupRepo = customerGroupRepo;
        }
        public MessageEnum CustomerGroupCreate(CustomerGroupDTO customerGroupDTO)
        {
            try
            {
                var customerGroup = _Context.CustomerGroups.Where(x => x.CustomerGroupId == customerGroupDTO.CustomerGroupId && x.Deleted == false).FirstOrDefault();
                if (customerGroup == null)
                {
                    _customerGroupRepo.Insert(new CustomerGroup()
                    {
                        CustomerGroupName = customerGroupDTO.CustomerGroupName,
                        CreatedBy = customerGroupDTO.CreatedBy,
                        CreatedDate = DateTime.Now,
                        Deleted = false
                    });
                    return MessageEnum.Success;
                }
                else
                    return MessageEnum.Duplicate;
            }
            catch
            {
                throw;
            }
        }

        public MessageEnum CustomerGroupDelete(int customerGroupId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.CustomerGroups.Where(x => x.CustomerGroupId == customerGroupId).FirstOrDefault();
                if (a != null)
                {
                    a.Deleted = true;
                    a.UpdatedBy = DeletedBy;
                    a.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();
                    return MessageEnum.Deleted;
                }
                else
                    return MessageEnum.Invalid;
            }
            catch
            {
                throw;
            }
        }

        public MessageEnum CustomerGroupUpdate(CustomerGroupDTO customerGroupDTO)
        {
            try
            {
                var customerGroup = _Context.CustomerGroups.Where(x => x.CustomerGroupId != customerGroupDTO.CustomerGroupId && x.CustomerGroupName == customerGroupDTO.CustomerGroupName && x.Deleted == false).FirstOrDefault();
                if (customerGroup == null)
                {
                    var a = _Context.CustomerGroups.Where(x => x.CustomerGroupId == customerGroupDTO.CustomerGroupId).FirstOrDefault();
                    if (a != null)
                    {
                        a.CustomerGroupName = customerGroupDTO.CustomerGroupName;
                        a.UpdatedBy = customerGroupDTO.CreatedBy;
                        a.UpdatedDate = DateTime.Now;

                        _Context.SaveChanges();
                        return MessageEnum.Updated;
                    }
                    else
                        return MessageEnum.Invalid;
                }
                else
                {
                    return MessageEnum.Duplicate;
                }

            }
            catch
            {
                throw;
            }
        }

        public CustomerGroup GetCustomerGroupByCustomerGroupId(int customerGroupId)
        {
            try
            {
                return _Context.CustomerGroups.Where(x => x.CustomerGroupId == customerGroupId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public CustomerGroup GetCustomerGroupByCustomerGroupName(string CustomerGroupName)
        {
            try
            {
                return _Context.CustomerGroups.Where(x => x.CustomerGroupName == CustomerGroupName && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<CustomerGroup> GetCustomerGroups()
        {
            try
            {
                return _Context.CustomerGroups.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }
    }
}
