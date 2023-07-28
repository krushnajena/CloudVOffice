using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Services.Authentication;
using CloudVOffice.Services.Users;
using CloudVOffice.Web.Model.User;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using CloudVOffice.Core.Domain.Pemission;
using Microsoft.AspNetCore.Identity;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Services.Emp;

namespace CloudVOffice.Web.Controllers
{
    public class AppController : Controller
    {
        private readonly IUserAuthenticationService _userauthenticationService;
        private readonly IUserService _userService;
        private readonly IEmployeeService _employeeService;
        public AppController(IUserAuthenticationService userauthenticationService, IUserService userService, IEmployeeService employeeService)
        {
            _userauthenticationService = userauthenticationService;
            _userService = userService;
            _employeeService = employeeService;
        }
        public IActionResult Login()
        {
           

			return View();
        }
       

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model, string? ReturnUrl)
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

                            var claims = new List<Claim>
                            {
                                new Claim(ClaimTypes.Email, userDetails.Email),
                                new Claim("FirstName",userDetails.FirstName),
                                new Claim("MiddleName",userDetails.MiddleName!=null?userDetails.MiddleName.ToString():""),
                                new Claim("LastName",userDetails.LastName!=null?userDetails.LastName.ToString():""),
                                new Claim("UserId",userDetails.UserId.ToString()),
								//  new Claim("Menu",menujson),
							};
                            var a = userDetails.UserRoleMappings;
                            var employee = _employeeService.GetEmployeeDetailsByUserId(userDetails.UserId);
                            if(employee!= null)
                            {
                             claims.Add(new Claim("EmployeeImage", employee.Photo));
                            }
                            claims.AddRange(userDetails.UserRoleMappings.Select(role => new Claim(ClaimTypes.Role, role.Role.RoleName)));

                            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                            var authProperties = new AuthenticationProperties() { IsPersistent = true };
                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);


                            return Redirect(ReturnUrl == null ? "/Applications" : ReturnUrl);
                        }
                    case UserLoginResults.UserNotExist:
                        ModelState.AddModelError("Email", "User Not Exists.");
                        break;
                    case UserLoginResults.Deleted:
                        ModelState.AddModelError("", "Account Has Been Deleted.");
                        break;

                    case UserLoginResults.NotActive:
                        ModelState.AddModelError("", "Account Has Been Suspended.");
                        break;

                    default:
                        ModelState.AddModelError("Password", "Invalid Credentials");
                        break;
                }
            }
            return View(model);
        }

        
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            //SignOutAsync is Extension method for SignOut    
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            //Redirect to home page    
            return LocalRedirect("/App/Login");
        }

        [HttpGet("/Applications")]
        [Authorize]
        public IActionResult Applications()
        {
            return View();
        }
        [HttpGet("/Forbidden")]
        public IActionResult Forbidden()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SetPassword(string token, string email)
        {
            SetPasswordModel setPasswordModel = new SetPasswordModel();
            setPasswordModel.Token = token;
            setPasswordModel.Email = email;

			return View(setPasswordModel);
        }

        [HttpPost]
        public IActionResult SetPassword(SetPasswordModel setPasswordModel)
        {
            if(ModelState.IsValid)
            {
                var a =_userService.SetPassword(setPasswordModel.Password, setPasswordModel.Email, setPasswordModel.Token);
                if (a == MessageEnum.Success)
                {
                    return RedirectToAction("PasswordSetSuccess");
                }
                else
                {
                    return RedirectToAction("PasswordSetFailure");
                }
            }
            else
            {
                return View(setPasswordModel);
            }
        }

        public IActionResult PasswordSetSuccess()
        {
            return View();
        }
        public IActionResult PasswordSetFailure()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }



    }
}
