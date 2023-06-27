using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Custom;
using CloudVOffice.Services.Custom;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Base.Controllers
{
	public class CustomerGroupController : BasePluginController
	{
		private readonly ICustomerGroupService _customerGroupService;
		public CustomerGroupController(ICustomerGroupService customerGroupService)
		{
			_customerGroupService = customerGroupService;
		}
		[HttpGet]
		public IActionResult CustomerGroupCreate(int? CustomerGroupId)
		{
			CustomerGroupDTO customerGroupDTO = new CustomerGroupDTO();
			if (CustomerGroupId != null)
			{
				var a = _customerGroupService.GetCustomerGroupByCustomerGroupId(int.Parse(CustomerGroupId.ToString()));
				customerGroupDTO.CustomerGroupName = a.CustomerGroupName;
			}
			return View("~/Plugins/Accounts.Base/Views/CustomerGroup/CustomerGroupCreate.cshtml", customerGroupDTO);
		}
		[HttpPost]
		public IActionResult CustomerGroupCreate(CustomerGroupDTO customerGroupDTO)
		{
			customerGroupDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


			if (ModelState.IsValid)
			{
				if (customerGroupDTO.CustomerGroupId == null)
				{
					var a = _customerGroupService.CustomerGroupCreate(customerGroupDTO);
					if (a == MessageEnum.Success)
					{
						TempData["msg"] = MessageEnum.Success;
						return Redirect("/Accounts/CustomerGroup/CustomerGroupView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "CustomerGroup Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _customerGroupService.CustomerGroupUpdate(customerGroupDTO);
					if (a == MessageEnum.Updated)
					{
						TempData["msg"] = MessageEnum.Updated;
						return Redirect("/Accounts/CustomerGroup/CustomerGroupView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "CustomerGroup Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}
			return View("~/Plugins/Accounts.Base/Views/CustomerGroup/CustomerGroupCreate.cshtml", customerGroupDTO);
		}
		public IActionResult CustomerGroupView()
		{
			ViewBag.customerGroups = _customerGroupService.GetCustomerGroups();

			return View("~/Plugins/Accounts.Base/Views/CustomerGroup/CustomerGroupView.cshtml");
		}

		[HttpGet]
		public IActionResult CustomerGroupDelete(int customerGroupId)
		{
			Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			var a = _customerGroupService.CustomerGroupDelete(customerGroupId, DeletedBy);
			TempData["msg"] = a;
			return Redirect("/Accounts/CustomerGroup/CustomerGroupView");
		}


	}

}

