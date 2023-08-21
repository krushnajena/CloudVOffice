using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HR.Attendance.Controllers

{
    [Area(AreaNames.Attendance)]
    public class LeavePeriodController : BasePluginController
    {
        private readonly ILeavePeriodService _leavePeriodService;
        public LeavePeriodController(ILeavePeriodService leavePeriodService)
        {

            _leavePeriodService = leavePeriodService;
        }
        [HttpGet]
        public IActionResult CreateLeavePeriod(int? leavePeriodId)
        {
            LeavePeriodDTO leavePeriodDTO = new LeavePeriodDTO();

            if (leavePeriodId != null)
            {

                LeavePeriod d = _leavePeriodService.GetLeavePeriodById(int.Parse(leavePeriodId.ToString()));

                leavePeriodDTO.FromDate = d.FromDate;
                leavePeriodDTO.ToDate = d.ToDate;

            }

            return View("~/Plugins/HR.Attendance/Views/LeavePeriod/CreateLeavePeriod.cshtml", leavePeriodDTO);

        }
        [HttpPost]
        public IActionResult CreateLeavePeriod(LeavePeriodDTO leavePeriodDTO)
        {
            leavePeriodDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            if (ModelState.IsValid)
            {
                bool isOverlap = _leavePeriodService.LeavePeriodOverlap(leavePeriodDTO.FromDate, leavePeriodDTO.ToDate, leavePeriodDTO.LeavePeriodId);

                if (!isOverlap)
                {
                    if (leavePeriodDTO.LeavePeriodId == null)
                    {
                        var a = _leavePeriodService.CreateLeavePeriod(leavePeriodDTO);
                        if (a == MessageEnum.Success)
                        {
                            TempData["msg"] = MessageEnum.Success;
                            return Redirect("/Attendance/LeavePeriod/LeavePeriodView");
                        }
                        else if (a == MessageEnum.Duplicate)
                        {
                            TempData["msg"] = MessageEnum.Duplicate;
                            ModelState.AddModelError("", "LeavePeriod Already Exists");
                        }
                        else
                        {
                            TempData["msg"] = MessageEnum.UnExpectedError;
                            ModelState.AddModelError("", "Un-Expected Error");
                        }
                    }
                    else
                    {
                        var a = _leavePeriodService.LeavePeriodUpdate(leavePeriodDTO);
                        if (a == MessageEnum.Updated)
                        {
                            TempData["msg"] = MessageEnum.Updated;
                            return Redirect("/Attendance/LeavePeriod/LeavePeriodView");
                        }
                        else if (a == MessageEnum.Duplicate)
                        {
                            TempData["msg"] = MessageEnum.Duplicate;
                            ModelState.AddModelError("", "LeavePeriod Already Exists");
                        }
                        else
                        {
                            TempData["msg"] = MessageEnum.UnExpectedError;
                            ModelState.AddModelError("", "Un-Expected Error");
                        }
                    }
                }
                else
                {
                    TempData["msg"] = MessageEnum.Duplicate;
                    ModelState.AddModelError("", "LeavePeriod overlaps with an existing LeavePeriod.");
                }
            }

            return View("~/Plugins/HR.Attendance/Views/LeavePeriod/CreateLeavePeriod.cshtml", leavePeriodDTO);
        }
        public IActionResult LeavePeriodView()
        {
            ViewBag.LeavePeriods = _leavePeriodService.GetLeavePeriodList();

            return View("~/Plugins/HR.Attendance/Views/LeavePeriod/LeavePeriodView.cshtml");
        }
        [HttpGet]

        public IActionResult LeavePeriodDelete(int leavePeriodId)
        {
            int DeletedBy = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _leavePeriodService.LeavePeriodDelete(leavePeriodId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Attendance/LeavePeriod/LeavePeriodView");
        }
       
    }
}
