
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Users
{
    public class UserCreateDTO
    {
        public Int64? UserId { get; set; }
		[Required]
		[DisplayName("First Name")]
        public string FirstName { get; set; }
		[DisplayName("Middle Name")]
		public string? MiddleName { get; set; }
		[DisplayName("Last Name")]
		public string? LastName { get; set; }

        [Required]
		[DisplayName("Email Id")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

        [Required]
		[DataType(DataType.Password)]
		[DisplayName("Password")]
		public string Password { get; set; }
        public string? PhoneNo { get; set; }
        public DateTime? DateOfBirth { get; set; }
		[DisplayName("User Type")]
		public int UserTypeId { get; set; }
        public Int64 CreatedBy { get; set; }
        public List<UserRolesDTO> roles { get; set; }
    }
    public class UserRolesDTO
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }    
        public bool IsSelected { get; set; }
    }
}
