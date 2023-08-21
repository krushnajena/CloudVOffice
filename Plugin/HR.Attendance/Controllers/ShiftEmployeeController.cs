using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.DTO.Emp;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Services.Emp;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;

namespace HR.Attendance.Controllers
{
    [Area(AreaNames.Attendance)]
    public class ShiftEmployeeController : BasePluginController
    {
        private readonly IShiftEmployeeService _shiftEmployeeService;
        private readonly IShiftTypeService _shiftTypeService;
        private readonly IEmployeeService _employeeService;
        public ShiftEmployeeController(IShiftEmployeeService shiftEmployeeService, IShiftTypeService shiftTypeService, IEmployeeService employeeService)
        {

            _shiftEmployeeService = shiftEmployeeService;
            _shiftTypeService = shiftTypeService;
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult ShiftEmployeeCreate(int? shiftEmployeeId)

        {
            ShiftEmployeeDTO shiftEmployeeDTO = new ShiftEmployeeDTO();

            if (shiftEmployeeId != null)
            {
                CloudVOffice.Core.Domain.HR.Attendance.ShiftEmployee d = _shiftEmployeeService.GetShiftEmployeeById(int.Parse(shiftEmployeeId.ToString()));
                shiftEmployeeDTO.ShiftId = d.ShiftId;
                shiftEmployeeDTO.EmployeeId = d.EmployeeId;
                shiftEmployeeDTO.FromDate = d.FromDate;
                shiftEmployeeDTO.ToDate = d.ToDate;



                /*var a = _employeeService.GetEmployeeById(int.Parse(shiftEmployeeId.ToString()));
                shiftEmployeeDTO.EmployeeShift = new List<EmployeeCreateDTO>();
                for (int i = 0; i < a.Count; i++)
                {
                    shiftEmployeeDTO.EmployeeShift.Add(new EmployeeCreateDTO
                    {
                        FullName = a[i].Employee.FullName,
                        EmployeeId = a[i].EmployeeId,
                    });
                }*/
            }

            var shiftType = _shiftTypeService.GetShiftTypeList();
            ViewBag.ShiftType = shiftType;

            var employee = _employeeService.GetEmployees();
            ViewBag.Employees = employee;

            return View("~/Plugins/HR.Attendance/Views/ShiftEmployee/ShiftEmployeeCreate.cshtml", shiftEmployeeDTO);

        }


        [HttpPost]
        public IActionResult ShiftEmployeeCreate(ShiftEmployeeDTO shiftEmployeeDTO)
        {
            shiftEmployeeDTO.CreatedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            if (shiftEmployeeDTO.EmployeesString != null && shiftEmployeeDTO.EmployeesString != "")
            {
                shiftEmployeeDTO.EmployeeShift = JsonConvert.DeserializeObject<List<EmployeeCreateDTO>>(shiftEmployeeDTO.EmployeesString);

            }
            if (ModelState.IsValid)
            {
                if (shiftEmployeeDTO.ShiftEmployeeId == null)
                {
                    var a = _shiftEmployeeService.CreateShiftEmployee(shiftEmployeeDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Attendance/ShiftEmployee/ShiftEmployeeView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "Shift Employee Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _shiftEmployeeService.ShiftEmployeeUpdate(shiftEmployeeDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Attendance/ShiftEmployee/ShiftEmployeeView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;

                        ModelState.AddModelError("", "Shift Employee Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }

            var shiftType = _shiftTypeService.GetShiftTypeList();
            ViewBag.ShiftType = shiftType;

            var employee = _employeeService.GetEmployees();
            ViewBag.Employees = employee;

            return View("~/Plugins/HR.Attendance/Views/ShiftEmployee/ShiftEmployeeCreate.cshtml", shiftEmployeeDTO);
        }
        public IActionResult ShiftEmployeeView()
        {
            ViewBag.ShiftEmployee = _shiftEmployeeService.GetShiftEmployeeList();

            return View("~/Plugins/HR.Attendance/Views/ShiftEmployee/ShiftEmployeeView.cshtml");
        }

        [HttpGet]
        public IActionResult DeleteShiftEmployee(int shiftEmployeeId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _shiftEmployeeService.ShiftEmployeeDelete(shiftEmployeeId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Attendance/ShiftEmployee/ShiftEmployeeView");
        }
    }
}
