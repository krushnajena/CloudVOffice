using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Customert;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Customert;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Customert
{
	public class CustomerService : ICustomerService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<Customer> _customerRepo;
		public CustomerService(ApplicationDBContext Context, ISqlRepository<Customer> customerRepo)
		{

			_Context = Context;
			_customerRepo = customerRepo;
		}
		public MessageEnum CustomerCreate(CustomerDTO customerDTO)
		{
			var objCheck = _Context.Customers.SingleOrDefault(opt => opt.CustomerId == customerDTO.CustomerId && opt.Deleted == false);
			try
			{
				if (objCheck == null)
				{

					Customer customer = new Customer();
					customer.CustomerName = customerDTO.CustomerName;
					customer.CustomerGroupId = customerDTO.CustomerGroupId;
					customer.TaxId = customerDTO.TaxId;
					customer.AccountManagerId = customerDTO.AccountManagerId;
					customer.AddressLine1 = customerDTO.AddressLine1;
					customer.AddressLine2 = customerDTO.AddressLine2;
					customer.City = customerDTO.City;
					customer.State = customerDTO.State;
					customer.Country = customerDTO.Country;
					customer.ZipCode = customerDTO.ZipCode;
					customer.PhoneNo = customerDTO.PhoneNo;
					customer.EmailId = customerDTO.EmailId;
					customer.ContactPersonName = customerDTO.ContactPersonName;
					customer.ContactPersonPhone = customerDTO.ContactPersonPhone;
					customer.ContactPersonEmailId = customerDTO.ContactPersonEmailId;
					customer.CreatedBy = customerDTO.CreatedBy;
					var obj = _customerRepo.Insert(customer);

					return MessageEnum.Success;
				}
				else if (objCheck != null)
				{
					return MessageEnum.Duplicate;
				}

				return MessageEnum.UnExpectedError;
			}
			catch
			{
				throw;
			}
		}

		public MessageEnum CustomerDelete(Int64 customerId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.Customers.Where(x => x.CustomerId == customerId).FirstOrDefault();
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

		public MessageEnum CustomerUpdate(CustomerDTO customerDTO)
		{
			try
			{
				var customer = _Context.Customers.Where(x => x.CustomerId != customerDTO.CustomerId && x.CustomerName == customerDTO.CustomerName && x.Deleted == false).FirstOrDefault();
				if (customer == null)
				{
					var a = _Context.Customers.Where(x => x.CustomerId == customerDTO.CustomerId).FirstOrDefault();
					if (a != null)
					{
						a.CustomerName = customerDTO.CustomerName;
						a.CustomerGroupId = customerDTO.CustomerGroupId;
						a.TaxId = customerDTO.TaxId;
						a.AccountManagerId = customerDTO.AccountManagerId;
						a.AddressLine1 = customerDTO.AddressLine1;
						a.AddressLine2 = customerDTO.AddressLine2;
						a.City = customerDTO.City;
						a.State = customerDTO.State;
						a.Country = customerDTO.Country;
						a.ZipCode = customerDTO.ZipCode;
						a.PhoneNo = customerDTO.PhoneNo;
						a.EmailId = customerDTO.EmailId;
						a.ContactPersonName = customerDTO.ContactPersonName;
						a.ContactPersonPhone = customerDTO.ContactPersonPhone;
						a.ContactPersonEmailId = customerDTO.ContactPersonEmailId;
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

		public Customer GetCustomerByCustomerId(Int64 customerId)
		{
			try
			{
				return _Context.Customers.Where(x => x.CustomerId == customerId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public Customer GetCustomerByCustomerName(string customerName)
		{
			try
			{
				return _Context.Customers.Where(x => x.CustomerName == customerName && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public List<Customer> GetCustomers()
		{
			try
			{
				return _Context.Customers.Where(x => x.Deleted == false).ToList();
			}
			catch
			{
				throw;
			}
		}
	}
}
