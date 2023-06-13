using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Customert;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Customert;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Services.Customert;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Services.Recruitment;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Accounts.Base.Controllers
{
	[Area(AreaNames.Accounts)]
	public class CustomerController : BasePluginController
	{
		private readonly ICustomerService _customerService;
		
		public CustomerController(ICustomerService customerService)
		{

			_customerService = customerService;
			
		}
		[HttpGet]
		public IActionResult CustomerCreate(Int64? customerId)
		{
            CustomerDTO customerDTO = new CustomerDTO();
			
			if (customerId != null)
			{

				var a = _customerService.GetCustomerByCustomerId(Int64.Parse(customerId.ToString()));

				customerDTO.CustomerName = a.CustomerName;
				customerDTO.CustomerGroupId = a.CustomerGroupId;
				customerDTO.TaxId = a.TaxId;
				customerDTO.AccountManagerId = a.AccountManagerId;
				customerDTO.AddressLine1 = a.AddressLine1;
				customerDTO.AddressLine2 = a.AddressLine2;
				customerDTO.City = a.City;
				customerDTO.State = a.State;
				customerDTO.Country = a.Country;
				customerDTO.ZipCode = a.ZipCode;
				customerDTO.PhoneNo = a.PhoneNo;
				customerDTO.EmailId = a.EmailId;
				customerDTO.ContactPersonName = a.ContactPersonName;
				customerDTO.ContactPersonPhone = a.ContactPersonPhone;
				customerDTO.ContactPersonEmailId = a.ContactPersonEmailId;


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
					var a = _customerService.CustomerCreate(customerDTO);
					if (a == MessageEnum.Success)
					{
						TempData["msg"] = MessageEnum.Success;
						return Redirect("/Accounts/Customer/CustomerView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "Customer Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _customerService.CustomerUpdate(customerDTO);
					if (a == MessageEnum.Updated)
					{
						TempData["msg"] = MessageEnum.Updated;
						return Redirect("/Accounts/Customer/CustomerView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "Customer Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}
			
			return View("~/Plugins/Accounts.Base/Views/Customer/CustomerCreate.cshtml", customerDTO);
		}

		
		public IActionResult CustomerView()
		{
			ViewBag.customers = _customerService.GetCustomers();

			return View("~/Plugins/Accounts.Base/Views/Customer/CustomerView.cshtml");
		}

		[HttpGet]
		public IActionResult CustomerDelete(int customerId)
		{
			Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			var a = _customerService.CustomerDelete(customerId, DeletedBy);
			TempData["msg"] = a;
			return Redirect("/Accounts/Customer/CustomerView");
		}


	}

	
}
