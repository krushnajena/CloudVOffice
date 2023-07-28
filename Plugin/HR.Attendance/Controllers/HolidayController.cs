using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;

namespace HR.Attendance.Controllers
{
	[Area(AreaNames.Attendance)]
    public class HolidayController : BasePluginController
    {
        private readonly IHolidayService _holidayService;
        private readonly IHolidayDaysService _holidayDaysService;
        public HolidayController(IHolidayService holidayService, IHolidayDaysService holidayDaysService)
        {

            _holidayService = holidayService;
            _holidayDaysService = holidayDaysService;
        }
        [Authorize(Roles = "HR Manager")]
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
                var holidaydays = _holidayDaysService.GetHolidayDaysById(int.Parse(HolidayId.ToString()));
                holidayDTO.HolidayDays = new List<HolidayDaysDTO>();
                //for (int i = 0; i < holidaydays.Count; i++)
                //{
                //    holidayDTO.HolidayDays.Add(new HolidayDaysDTO
                //    {
                //        HolidayId = holidaydays[i].HolidayId,
                //        ForDate = holidaydays[i].ForDate,
                //        Description = holidaydays[i].Description,
                //    });
                //}
                holidayDTO.holidayDaysString = JsonConvert.SerializeObject(holidayDTO.HolidayDays);

            }
            else
            {
                holidayDTO.HolidayDays = new List<HolidayDaysDTO>();
            }
            var holidayDays = _holidayDaysService.GetHolidayDaysList();
            ViewBag.HolidayDays = holidayDays;


            return View("~/Plugins/HR.Attendance/Views/Holiday/CreateHoliday.cshtml", holidayDTO);

        }

        [HttpPost]
        [Authorize(Roles = "HR Manager")]
        public IActionResult CreateHoliday(HolidayDTO holidayDTO)
        {
            holidayDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            holidayDTO.HolidayDays = JsonConvert.DeserializeObject<List<HolidayDaysDTO>>(holidayDTO.holidayDaysString);
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
        [Authorize(Roles = "HR Manager")]
        public IActionResult DeleteHoliday(int HolidayId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _holidayService.HolidayDelete(HolidayId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Attendance/Holiday/HolidayView");
        }
    }
}
