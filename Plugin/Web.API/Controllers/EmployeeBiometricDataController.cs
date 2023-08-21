using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Services.Emp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeBiometricDataController : Controller
    {
        private readonly IEmployeeBiometricDataService _employeeBiometricDataService;
        private readonly IEmployeeService _empolyeeService;
        private readonly IWebHostEnvironment _hostingEnvironment;


        public EmployeeBiometricDataController(
           IEmployeeBiometricDataService employeeBiometricDataService,
           IEmployeeService empolyeeService,
            IWebHostEnvironment hostingEnvironment
       )
        {
            _employeeBiometricDataService = employeeBiometricDataService;
            _empolyeeService = empolyeeService;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        [Authorize]
        public IActionResult CreateEmployeeBiometricData([FromForm] EmployeeBiometricDataDTO employeeBiometricDataDTO)
        {
            employeeBiometricDataDTO.CreatedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _empolyeeService.GetEmployeeDetailsByUserId(employeeBiometricDataDTO.CreatedBy);
            string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, @"uploads\EmployeeBiomatricData");

            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }
            if (employeeBiometricDataDTO.ISOImage1Up != null)
            {

                string imagePath = Path.Combine(uploadsFolder, employeeBiometricDataDTO.ISOImage1Up.FileName);
                employeeBiometricDataDTO.ISOTemplate1Up.CopyTo(new FileStream(imagePath, FileMode.Create));
                employeeBiometricDataDTO.ISOImage1 = imagePath;

            }

            if (employeeBiometricDataDTO.ISOTemplate1Up != null)
            {


                string imagePath = Path.Combine(uploadsFolder, employeeBiometricDataDTO.ISOTemplate1Up.FileName);
                employeeBiometricDataDTO.ISOTemplate1Up.CopyTo(new FileStream(imagePath, FileMode.Create));
                employeeBiometricDataDTO.ISOTemplate1 = imagePath;



            }

            if (employeeBiometricDataDTO.AnsiTemplate1Up != null)
            {
                string imagePath = Path.Combine(uploadsFolder, employeeBiometricDataDTO.AnsiTemplate1Up.FileName);
                employeeBiometricDataDTO.AnsiTemplate1Up.CopyTo(new FileStream(imagePath, FileMode.Create));
                employeeBiometricDataDTO.AnsiTemplate1 = imagePath;




            }

            if (employeeBiometricDataDTO.RawData1Up != null)

            {
                string imagePath = Path.Combine(uploadsFolder, employeeBiometricDataDTO.RawData1Up.FileName);
                employeeBiometricDataDTO.RawData1Up.CopyTo(new FileStream(imagePath, FileMode.Create));
                employeeBiometricDataDTO.RawData1 = imagePath;




            }

            if (employeeBiometricDataDTO.WSQImage1Up != null)

            {
                string imagePath = Path.Combine(uploadsFolder, employeeBiometricDataDTO.WSQImage1Up.FileName);
                employeeBiometricDataDTO.WSQImage1Up.CopyTo(new FileStream(imagePath, FileMode.Create));
                employeeBiometricDataDTO.WSQImage1 = imagePath;




            }
            if (employeeBiometricDataDTO.ISOImage2Up != null)

            {
                string imagePath = Path.Combine(uploadsFolder, employeeBiometricDataDTO.ISOImage2Up.FileName);
                employeeBiometricDataDTO.ISOImage2Up.CopyTo(new FileStream(imagePath, FileMode.Create));
                employeeBiometricDataDTO.ISOImage2 = imagePath;


            }
            if (employeeBiometricDataDTO.ISOTemplate2Up != null)

            {
                string imagePath = Path.Combine(uploadsFolder, employeeBiometricDataDTO.ISOTemplate2Up.FileName);
                employeeBiometricDataDTO.ISOTemplate2Up.CopyTo(new FileStream(imagePath, FileMode.Create));
                employeeBiometricDataDTO.ISOTemplate2 = imagePath;



            }
            if (employeeBiometricDataDTO.AnsiTemplate2Up != null)

            {
                string imagePath = Path.Combine(uploadsFolder, employeeBiometricDataDTO.AnsiTemplate2Up.FileName);
                employeeBiometricDataDTO.AnsiTemplate2Up.CopyTo(new FileStream(imagePath, FileMode.Create));
                employeeBiometricDataDTO.AnsiTemplate2 = imagePath;



            }

            if (employeeBiometricDataDTO.RawData2Up != null)

            {
                string imagePath = Path.Combine(uploadsFolder, employeeBiometricDataDTO.RawData2Up.FileName);
                employeeBiometricDataDTO.RawData2Up.CopyTo(new FileStream(imagePath, FileMode.Create));
                employeeBiometricDataDTO.RawData2 = imagePath;


            }

            if (employeeBiometricDataDTO.WSQImage2Up != null)

            {
                string imagePath = Path.Combine(uploadsFolder, employeeBiometricDataDTO.WSQImage2Up.FileName);
                employeeBiometricDataDTO.WSQImage2Up.CopyTo(new FileStream(imagePath, FileMode.Create));
                employeeBiometricDataDTO.WSQImage2 = imagePath;



            }

            if (employeeBiometricDataDTO.ISOImage3Up != null)

            {

                string imagePath = Path.Combine(uploadsFolder, employeeBiometricDataDTO.ISOImage3Up.FileName);
                employeeBiometricDataDTO.ISOImage3Up.CopyTo(new FileStream(imagePath, FileMode.Create));
                employeeBiometricDataDTO.ISOImage3 = imagePath;



            }

            if (employeeBiometricDataDTO.ISOTemplate3Up != null)

            {
                string imagePath = Path.Combine(uploadsFolder, employeeBiometricDataDTO.ISOTemplate3Up.FileName);
                employeeBiometricDataDTO.ISOTemplate3Up.CopyTo(new FileStream(imagePath, FileMode.Create));
                employeeBiometricDataDTO.ISOTemplate3 = imagePath;






            }

            if (employeeBiometricDataDTO.AnsiTemplate3Up != null)

            {
                string imagePath = Path.Combine(uploadsFolder, employeeBiometricDataDTO.AnsiTemplate3Up.FileName);
                employeeBiometricDataDTO.AnsiTemplate3Up.CopyTo(new FileStream(imagePath, FileMode.Create));
                employeeBiometricDataDTO.AnsiTemplate3 = imagePath;


            }

            if (employeeBiometricDataDTO.RawData3Up != null)

            {
                string imagePath = Path.Combine(uploadsFolder, employeeBiometricDataDTO.RawData3Up.FileName);
                employeeBiometricDataDTO.RawData3Up.CopyTo(new FileStream(imagePath, FileMode.Create));
                employeeBiometricDataDTO.RawData3 = imagePath;


            }

            if (employeeBiometricDataDTO.WSQImage3Up != null)

            {
                string imagePath = Path.Combine(uploadsFolder, employeeBiometricDataDTO.WSQImage3Up.FileName);
                employeeBiometricDataDTO.WSQImage3Up.CopyTo(new FileStream(imagePath, FileMode.Create));
                employeeBiometricDataDTO.WSQImage3 = imagePath;


            }



            var a = _employeeBiometricDataService.CreateEmployeeBiometricData(employeeBiometricDataDTO);


            return Ok(a);
        }


    }




}
