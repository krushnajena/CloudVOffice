using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Data.DTO.Users;
using CloudVOffice.Services.Roles;
using CloudVOffice.Services.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CloudVOffice.Web.Areas.Setup.Controllers
{
	public class EmailAccountController : Controller
	{
		private readonly IUserService _userService;
		public EmailAccountController(IUserService userService)
		{
			_userService = userService;
		}
		
	}


}
