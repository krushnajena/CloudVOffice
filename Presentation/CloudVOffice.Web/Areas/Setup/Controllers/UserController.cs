using CloudVOffice.Data.DTO.Users;
using CloudVOffice.Services.Users;
using CloudVOffice.Web.Framework;
using Microsoft.AspNetCore.Mvc;

namespace CloudVOffice.Web.Areas.Setup.Controllers
{
    [Area(AreaNames.Setup)]
    public class UserController : Controller
    {
        private readonly UserService _userService;
        public UserController(UserService userService) {

            _userService = userService;
        }
        public IActionResult UserList()
        {
            return View();
        }
        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(UserCreateDTO createUserDTO)
        {
            if(ModelState.IsValid)
            {
              var a= await  _userService.CreateUser(createUserDTO); 
              if(a != null)
                {
                    if(a== "Success")
                    {
                        return Redirect("/Setup/User/UserList");
                    }
                    else if (a == "Duplicate")
                    {
                        ModelState.AddModelError("", "User Already Exists");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Un-Expected Error");
                    }

                }
                else
                {
                    ModelState.AddModelError("", "Un-Expected Error");
                }
            }

            return  View(createUserDTO);
        }
    }
}
