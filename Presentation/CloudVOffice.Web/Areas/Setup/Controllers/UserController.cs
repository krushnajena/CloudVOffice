using CloudVOffice.Data.DTO.Users;
using CloudVOffice.Services.Roles;
using CloudVOffice.Services.Users;
using CloudVOffice.Web.Framework;
using Microsoft.AspNetCore.Mvc;

namespace CloudVOffice.Web.Areas.Setup.Controllers
{
    [Area(AreaNames.Setup)]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
		private readonly IRoleService _roleService;
		public UserController(IUserService userService,
			IRoleService roleService
			) {

            _userService = userService;
            _roleService= roleService;

		}
        public IActionResult UserList()
        {
            ViewBag.UserList = _userService.GetAllUsers();
            return View();
        }
        public IActionResult CreateUser()
        {
			UserCreateDTO userCreateDTO = new UserCreateDTO();
            var roles = _roleService.GetAllRoles();
            for (int i = 0; i < roles.Count; i++)
            {
                userCreateDTO.roles.Add(new UserRolesDTO( ){
                    IsSelected = false,
                    RoleId = roles[i].RoleId,
                    RoleName = roles[i].RoleName }) ;

		    }
               
			return View(userCreateDTO);
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
