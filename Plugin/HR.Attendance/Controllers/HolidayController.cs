using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Attendance.Controllers
{
    [Area(AreaNames.Attendance)]
    public class HolidayController : BasePluginController
    {
        private readonly IHolidayService _holidayService;
        public HolidayController(IHolidayService holidayService)
        {

            _holidayService = holidayService;
        }

        [HttpGet]
        public IActionResult CreateHoliday(int? HolidayId)
        {
            HolidayDTO holidayDTO = new HolidayDTO();
            if (HolidayId != null)
            {

                var d = _holidayService.GetHolidayById(int.Parse(HolidayId.ToString()));

                holidayDTO.HolidayName = d.HolidayName;
                holidayDTO.FromDate = d.FromDate;
                holidayDTO.ToDate = d.ToDate;
            }

            return View("~/Plugins/HR.Attendance/Views/Holiday/CreateHoliday.cshtml", holidayDTO);


        }

        [HttpPost]
        public IActionResult CreateHoliday(HolidayDTO holidayDTO)
        {
            holidayDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (holidayDTO.HolidayId == null)
                {
                    var a = _holidayService.CreateHoliday(holidayDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Attendance/Holiday/HolidayView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "Holiday Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _holidayService.HolidayUpdate(holidayDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Attendance/Holiday/HolidayView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "Holiday Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
            return View("~/Plugins/HR.Attendance/Views/Holiday/CreateHoliday.cshtml", holidayDTO);
        }

        [Authorize(Roles = "HR Manager")]
        public IActionResult HolidayView()
        {
            ViewBag.Holiday = _holidayService.GetHolidayList();

            return View("~/Plugins/HR.Attendance/Views/Holiday/HolidayView.cshtml");
        }

        [HttpGet]
        public IActionResult DeleteHoliday(int HolidayId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _holidayService.HolidayDelete(HolidayId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Attendance/Holiday/HolidayView");
        }
    }
}
