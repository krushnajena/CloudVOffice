using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Users
{
    public class UserCreateDTO
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string? PhoneNo { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int UserTypeId { get; set; }
        public int CreatedBy { get; set; }
        public List<UserRolesDTO> roles { get; set; }
    }
    public class UserRolesDTO
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }    
        public bool IsSelected { get; set; }
    }
}
