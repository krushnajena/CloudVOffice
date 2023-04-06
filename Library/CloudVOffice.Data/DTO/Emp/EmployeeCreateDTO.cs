using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Emp
{
    public class EmployeeCreateDTO
    {
        public string EmployeeCode { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public int ErpUser { get; set; }
        public bool Status { get; set; }
       
        public string MobileNo { get; set; }
        public string PersonalEmail { get; set; }
        public string CompanyEmail { get; set; }
        public string CurrentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyPhone { get; set; }

    }
}
