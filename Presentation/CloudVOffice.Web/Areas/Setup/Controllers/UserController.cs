using CloudVOffice.Data.DTO.Users;
using CloudVOffice.Services.Roles;
using CloudVOffice.Services.Users;
using CloudVOffice.Web.Framework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            var a = _userService.GetAllUsers();
            ViewBag.UserList = a;
            return View();
        }
        public IActionResult CreateUser()
        {
            UserCreateDTO userCreateDTO = new UserCreateDTO();
            userCreateDTO.roles = new List<UserRolesDTO>();
            var roles = _roleService.GetAllRoles();
           
            ViewBag.UserTypeList = new SelectList((System.Collections.IEnumerable)_userService.GetUserTypes(), "ID", "Name");
			for (int i = 0; i < roles.Count; i++)
            {
                UserRolesDTO userRolesDTO   = new UserRolesDTO();
                userRolesDTO.IsSelected = false;
                userRolesDTO.RoleId = roles[i].RoleId;
                userRolesDTO.RoleName = roles[i].RoleName;
                userCreateDTO.roles.Add(userRolesDTO) ;

		    }
               
			return View(userCreateDTO);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateUser(UserCreateDTO createUserDTO)
        {

            createUserDTO.CreatedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			if (ModelState.IsValid)
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
			ViewBag.UserTypeList = new SelectList((System.Collections.IEnumerable)_userService.GetUserTypes(), "ID", "Name");

			return View(createUserDTO);
        }
    }
}
