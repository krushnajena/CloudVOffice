using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Services.Emp;
using CloudVOffice.Services.Recruitment;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Recruitment.Controllers
{
    [Area(AreaNames.Recruitment)]
    public class RecruitClientController : BasePluginController
    {
        private readonly IRecruitClientService _RecruitClientService;
        private readonly IEmployeeService _employeeService;
        public RecruitClientController(IRecruitClientService RecruitClientService, IEmployeeService employeeService)
        {

            _RecruitClientService = RecruitClientService;
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult RecruitClientCreate(int? recruitClientId)
        {
            RecruitClientDTO recruitClientDTO = new RecruitClientDTO();

            var employee = _employeeService.GetEmployees();
            ViewBag.AccountManager = employee;

            if (recruitClientId != null)
            {

                var d = _RecruitClientService.GetRecruitClientById(int.Parse(recruitClientId.ToString()));

                recruitClientDTO.ClientName = d.ClientName;
                recruitClientDTO.ContactNo = d.ContactNo;
                recruitClientDTO.AccountManagerId = d.AccountManagerId;
                recruitClientDTO.Website = d.Website;
                recruitClientDTO.Fax = d.Fax;
                recruitClientDTO.About = d.About;
                recruitClientDTO.BillingAddressLine1 = d.BillingAddressLine1;
                recruitClientDTO.BillingAddressLine2 = d.BillingAddressLine2;
                recruitClientDTO.BillingCity = d.BillingCity;
                recruitClientDTO.BillingState = d.BillingState;
                recruitClientDTO.BillingCountry = d.BillingCountry;
                recruitClientDTO.BillingPostalCode = d.BillingPostalCode;
            }

            return View("~/Plugins/HR.Recruitment/Views/RecruitClient/RecruitClientCreate.cshtml", recruitClientDTO);

        }

        [HttpPost]
        public IActionResult RecruitClientCreate(RecruitClientDTO recruitClientDTO)
        {
            recruitClientDTO.CreatedBy = (int)long.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (recruitClientDTO.RecruitClientId == null)
                {
                    var a = _RecruitClientService.RecruitClientCreate(recruitClientDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Recruitment/RecruitClient/RecruitClientView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "RecruitClient Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _RecruitClientService.RecruitClientUpdate(recruitClientDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Recruitment/RecruitClient/RecruitClientView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "RecruitClient Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
            var employee = _employeeService.GetEmployees();
            ViewBag.AccountManager = employee;
            return View("~/Plugins/HR.Recruitment/Views/RecruitClient/RecruitClientCreate.cshtml", recruitClientDTO);
        }

        public IActionResult RecruitClientView()
        {
            ViewBag.RecruitClient = _RecruitClientService.GetRecruitClientList();

            return View("~/Plugins/HR.Recruitment/Views/RecruitClient/RecruitClientView.cshtml");
        }
        [HttpGet]
        public IActionResult RecruitClientDelete(int recruitClientId)
        {
            int DeletedBy = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _RecruitClientService.RecruitClientDelete(recruitClientId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Recruitment/RecruitClient/RecruitClientView");
        }


    }
}
