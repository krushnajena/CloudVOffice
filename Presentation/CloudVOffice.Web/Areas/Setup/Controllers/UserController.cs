using CloudVOffice.Core.Domain.Users;
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
        public IActionResult CreateUser(Int64? UserId)
        {

            UserCreateDTO userCreateDTO;
            var roles = _roleService.GetAllRoles();

            if (UserId == null)
            {
                userCreateDTO = new UserCreateDTO();
                userCreateDTO.roles = new List<UserRolesDTO>();
                for (int i = 0; i < roles.Count; i++)
                {
                    UserRolesDTO userRolesDTO = new UserRolesDTO();

                    userRolesDTO.IsSelected = false;
                    userRolesDTO.RoleId = roles[i].RoleId;
                    userRolesDTO.RoleName = roles[i].RoleName;
                    userCreateDTO.roles.Add(userRolesDTO);

                }
            }
            else
            {
                User user = _userService.GetUserByUserId(int.Parse(UserId.ToString()));
                userCreateDTO = new UserCreateDTO();
				userCreateDTO.UserId = user.UserId;
				userCreateDTO.FirstName = user.FirstName;
                userCreateDTO.MiddleName = user.MiddleName;
                userCreateDTO.LastName = user.LastName;
                userCreateDTO.Email = user.Email;
                userCreateDTO.PhoneNo = user.PhoneNo;

                userCreateDTO.DateOfBirth = user.DateOfBirth;
                userCreateDTO.UserTypeId = user.UserTypeId;
                userCreateDTO.roles = new List<UserRolesDTO>();
                for (int i = 0; i < roles.Count; i++)
                {
                    UserRolesDTO userRolesDTO = new UserRolesDTO();
                    userRolesDTO.IsSelected = false;
                    for (int j=0; j < user.UserRoleMappings.Count; j++)
                    {
                        if (user.UserRoleMappings[j].RoleId == roles[i].RoleId)
                        {
                            userRolesDTO.IsSelected = true;
                        }
                       
                    }
                   
                    userRolesDTO.RoleId = roles[i].RoleId;
                    userRolesDTO.RoleName = roles[i].RoleName;
                    userCreateDTO.roles.Add(userRolesDTO);

                }

            }
           
          
            ViewBag.UserTypeList = new SelectList((System.Collections.IEnumerable)_userService.GetUserTypes(), "ID", "Name");
          
			
            

               
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

        [HttpGet]
        public IActionResult DeleteUser(Int64 UserId)
        {
            Int64 DeletedBy= Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _userService.DeleteUser(UserId, DeletedBy);
			return Redirect("/Setup/User/UserList");
		}
    }
}
