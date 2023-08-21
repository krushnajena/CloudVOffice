using CloudVOffice.Core.Domain.Common;

using CloudVOffice.Data.DTO.Custom;
using CloudVOffice.Services.Custom;
using CloudVOffice.Services.Emp;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Accounts.Base.Controllers
{
    [Area(AreaNames.Accounts)]
    public class CustomerController : BasePluginController
    {
        private readonly ICustomerService _CustomerService;
        private readonly ICustomerGroupService _CustomerGroupService;
        private readonly IEmployeeService _empolyeeService;
        public CustomerController(ICustomerService CustomerService, ICustomerGroupService customerGroupService, IEmployeeService employeeService)
        {

            _CustomerService = CustomerService;
            _CustomerGroupService = customerGroupService;
            _empolyeeService = employeeService;
        }
        [HttpGet]
        public IActionResult CustomerCreate(Int64? customerId)
        {
            CustomerDTO customerDTO = new CustomerDTO();

            var CustomerGroup = _CustomerGroupService.GetCustomerGroups();
            ViewBag.CustomerGroups = CustomerGroup;

            var employee = _empolyeeService.GetEmployees();
            ViewBag.Employees = employee;

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

            return View("~/Plugins/Accounts.Base/Views/Custom/CustomerCreate.cshtml", customerDTO);

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
                    var a = _CustomerService.CustomerUpdate(customerDTO);
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
            var CustomerGroup = _CustomerGroupService.GetCustomerGroups();
            ViewBag.CustomerGroups = CustomerGroup;

            var employee = _empolyeeService.GetEmployees();
            ViewBag.Employees = employee;
            return View("~/Plugins/Accounts.Base/Views/Custom/CustomerCreate.cshtml", customerDTO);
        }
        public IActionResult CustomerView()
        {
            ViewBag.customer = _CustomerService.GetCustomers();

            return View("~/Plugins/Accounts.Base/Views/Custom/CustomerView.cshtml");
        }

        [HttpGet]
        public IActionResult CustomerDelete(Int64 customerId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _CustomerService.CustomerDelete(customerId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Accounts/Customer/CustomerView");
        }
    }
}
