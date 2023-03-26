using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CloudVOffice.Web.Model.User
{
    public partial record LoginModel
    {
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Id")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}
