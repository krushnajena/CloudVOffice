using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Customert;
using CloudVOffice.Services.Customert;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Accounts.Base.Controllers
{
    [Area(AreaNames.Accounts)]
	public class CustomerController:BasePluginController
	{
		private readonly ICustomerService _CustomerService;
		public CustomerController(ICustomerService CustomerService)
		{

			_CustomerService = CustomerService;
		}
		[HttpGet]
		public IActionResult CustomerCreate(Int64? customerId)
		{
			CustomerDTO customerDTO = new CustomerDTO();
			var customers = _CustomerService.GetCustomers();
			
			if (customerId != null)
			{

				var d = _CustomerService.GetCustomerByCustomerId(int.Parse(customerId.ToString()));

				customerDTO.CustomerName = d.CustomerName;
				customerDTO.CustomerGroupId = d.CustomerGroupId;
				customerDTO.TaxId = d.TaxId;
				customerDTO.AccountManagerId = d.AccountManagerId;
				customerDTO.AddressLine1 = d.AddressLine1;
				customerDTO.AddressLine2 = d.AddressLine2;
				customerDTO.City = d.City;
				customerDTO.State = d.State;
				customerDTO.Country = d.Country;
				customerDTO.ZipCode = d.ZipCode;
				customerDTO.PhoneNo = d.PhoneNo;
				customerDTO.EmailId = d.EmailId;
				customerDTO.ContactPersonName = d.ContactPersonName;
				customerDTO.ContactPersonPhone = d.ContactPersonPhone;
				customerDTO.ContactPersonEmailId = d.ContactPersonEmailId;

			}

			return View("~/Plugins/Accounts.Base/Views/Customer/CustomerCreate.cshtml", customerDTO);

		}
        [HttpPost]
        public IActionResult CustomerCreate(CustomerDTO customerDTO)
        {
            customerDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (customerDTO.CustomerId == null)
                {
                    var a = _CustomerService.CustomerCreate(customerDTO);
                    if (a == MessageEnum.Success)
                    {
                       
                        return Redirect("/Accounts/Customer/CustomerView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                       
                        ModelState.AddModelError("", "Customer Already Exists");
                    }
                    else
                    {
                       
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _CustomerService.CustomerUpdate(customerDTO);
                    if (a == MessageEnum.Updated)
                    {
                       
                        return Redirect("/Accounts/Customer/CustomerView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                       
                        ModelState.AddModelError("", "Customer Already Exists");
                    }
                    else
                    {
                        
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }

            return View("~/Plugins/Accounts.Base/Views/Customer/CustomerCreate.cshtml", customerDTO);
        }
    }
}
