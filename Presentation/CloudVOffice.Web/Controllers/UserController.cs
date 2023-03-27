using CloudVOffice.Core.Domain.User;
using CloudVOffice.Services.Authentication;
using CloudVOffice.Services.Users;
using CloudVOffice.Web.Model.User;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace CloudVOffice.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserAuthenticationService _userauthenticationService;
        private readonly IUserService _userService;
        public UserController(IUserAuthenticationService userauthenticationService, IUserService userService)
        {
            _userauthenticationService = userauthenticationService;
            _userService = userService;
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
                                new Claim("UserId",userDetails.Id.ToString()),
                            };
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
            return LocalRedirect("/User/Login");
        }

        [HttpGet("/Applications")]
        [Authorize]
        public IActionResult Applications()
        {
            return View();
        }
    }
}
