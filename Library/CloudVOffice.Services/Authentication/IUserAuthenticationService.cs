using CloudVOffice.Core.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Authentication
{
    public interface IUserAuthenticationService
    {
        public  Task<UserLoginResults> ValidateUserAsync(string EmailId, string Password);
      

    }
}
