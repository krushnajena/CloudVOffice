using CloudVOffice.Services.Authentication;
using CloudVOffice.Services.Users;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CludVOffice.WebApi.Controllers.Users
{
    public class UserDetailsControllers:BaseController
    {
        private readonly IUserAuthenticationService _userauthenticationService;
        private readonly IUserService _userService;
        public UserDetailsControllers(IUserAuthenticationService userauthenticationService, IUserService userService)
        {
            _userauthenticationService = userauthenticationService;
            _userService = userService;
        }
        public async Task<IActionResult> GetNewUserDetails(string emailid)
        {
            var a = await _userService.GetUserByEmailAsync(emailid);
            return Ok(a);
        }
    }
}
