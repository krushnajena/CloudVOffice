using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Services.Authentication;
using CloudVOffice.Services.Users;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CloudVOffice.Web.Model.User;
using CloudVOffice.Core.Domain.Pemission;

namespace Web.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly IUserAuthenticationService _userauthenticationService;
        private readonly IUserService _userService;
        public LoginController(IUserAuthenticationService userauthenticationService, IUserService userService)
        {
            _userauthenticationService = userauthenticationService;
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var Email = model.Email?.Trim();
                var loginResult = await _userauthenticationService.ValidateUserAsync(Email, model.Password);
                switch (loginResult)
                {
                    case UserLoginResults.Successful:
                        {
                            var userDetails = await _userService.GetUserByEmailAsync(Email);
                           return Ok(userDetails);

                         
                        }
                    case UserLoginResults.UserNotExist:
                        {
                            
                            return BadRequest("User Not Exists.");
                         
                        }
                    case UserLoginResults.Deleted:
                        BadRequest("Account Has Been Deleted.");
                        break;

                    case UserLoginResults.NotActive:
                        BadRequest("Account Has Been Suspended.");
                        break;

                    default:
                        BadRequest("Invalid Credentials");
                        break;
                }
            }
            return BadRequest(model);
        }

    }
}
