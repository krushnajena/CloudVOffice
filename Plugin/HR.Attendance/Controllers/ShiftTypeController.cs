using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HR.Attendance.Controllers
{
    [Area(AreaNames.Attendance)]
    public class ShiftTypeController : BasePluginController
    {
        private readonly IShiftTypeService _shiftTypeService;
        public ShiftTypeController(IShiftTypeService shiftTypeService)
        {

            _shiftTypeService = shiftTypeService;
        }
        [HttpGet]
        public IActionResult CreateShiftType(int? ShiftTypeId)
        {
            ShiftTypeDTO shiftTypeDTO = new ShiftTypeDTO();
            if (ShiftTypeId != null)
            {

                var d = _shiftTypeService.GetShiftTypeById(int.Parse(ShiftTypeId.ToString()));

                shiftTypeDTO.ShiftTypeName = d.ShiftTypeName;
                shiftTypeDTO.StartTime = d.StartTime;
                shiftTypeDTO.EndTime = d.EndTime;
                shiftTypeDTO.LateEntryGracePeriodInMinutes = d.LateEntryGracePeriodInMinutes;
                shiftTypeDTO.EarlyExitGracePeriodInMinutes = d.EarlyExitGracePeriodInMinutes;
                shiftTypeDTO.ThresholdforHalfDayInHours = d.ThresholdforHalfDayInHours;
                shiftTypeDTO.ThresholdforAbsentInHours = d.ThresholdforAbsentInHours;

            }

            return View("~/Plugins/HR.Attendance/Views/ShiftType/CreateShiftType.cshtml", shiftTypeDTO);


        }

        [HttpPost]
        public IActionResult CreateShiftType(ShiftTypeDTO shiftTypeDTO)
        {
            shiftTypeDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (shiftTypeDTO.ShiftTypeId == null)
                {
                    var a = _shiftTypeService.CreateShiftType(shiftTypeDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Attendance/ShiftType/ShiftTypeView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "ShiftType Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _shiftTypeService.ShiftTypeUpdate(shiftTypeDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Attendance/ShiftType/ShiftTypeView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "ShiftType Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
            return View("~/Plugins/HR.Attendance/Views/ShiftType/CreateShiftType.cshtml", shiftTypeDTO);
        }

        [Authorize(Roles = "HR Manager")]
        public IActionResult ShiftTypeView()
        {
            ViewBag.shiftType = _shiftTypeService.GetShiftTypeList();

            return View("~/Plugins/HR.Attendance/Views/ShiftType/ShiftTypeView.cshtml");
        }

        [HttpGet]
        public IActionResult DeleteShiftType(int shiftTypeId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _shiftTypeService.ShiftTypeDelete(shiftTypeId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Attendance/ShiftType/ShiftTypeView");
        }
    }
}
