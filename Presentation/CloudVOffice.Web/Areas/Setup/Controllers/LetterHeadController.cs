using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Company;
using CloudVOffice.Core.Domain.Comunication;
using CloudVOffice.Data.DTO.Company;
using CloudVOffice.Data.DTO.Comunication;
using CloudVOffice.Services.Company;
using CloudVOffice.Services.Comunication;
using CloudVOffice.Web.Framework;
using Microsoft.AspNetCore.Mvc;

namespace CloudVOffice.Web.Areas.Setup.Controllers
{
	[Area(AreaNames.Setup)]
	public class LetterHeadController : Controller
	{
		private readonly ILetterHeadService _letterHeadService;
		public LetterHeadController(ILetterHeadService letterHeadService)
		{

			_letterHeadService = letterHeadService;
		}
		[HttpGet]
		public IActionResult LetterHeadCreate(int? letterHeadId)
		{
			LetterHeadDTO letterHeadDTO = new LetterHeadDTO();

			if (letterHeadId != null)
			{

				LetterHead d = _letterHeadService.GetLetterHeadByLetterHeadId(int.Parse(letterHeadId.ToString()));

				letterHeadDTO.LetterHeadName = d.LetterHeadName;
				letterHeadDTO.LetterHeadImage = d.LetterHeadImage;
				letterHeadDTO.LetterHeadImageHeight = d.LetterHeadImageHeight;
				letterHeadDTO.LetterHeadImageWidth = d.LetterHeadImageWidth;
				letterHeadDTO.LetterHeadAlign = d.LetterHeadAlign;
				letterHeadDTO.LetterHeadFooterImage = d.LetterHeadFooterImage;
				letterHeadDTO.LetterHeadImageFooterHeight = d.LetterHeadImageFooterHeight;
				letterHeadDTO.LetterHeadImageFooterWidth = d.LetterHeadImageFooterWidth;
				letterHeadDTO.LetterHeadFooterAlign = d.LetterHeadFooterAlign;
				

			}

			return View("~/Areas/Setup/Views/LetterHead/LetterHeadCreate.cshtml", letterHeadDTO);

		}
		[HttpPost]
		public IActionResult LetterHeadCreate(LetterHeadDTO letterHeadDTO)
		{
			letterHeadDTO.CreatedBy = int.Parse(User.Claims.SingleOrDefault(x => x.Type == "UserId").Value.ToString());


			if (ModelState.IsValid)
			{
				if (letterHeadDTO.LetterHeadId == null)
				{
					var a = _letterHeadService.LetterHeadCreate(letterHeadDTO);
					if (a == MennsageEnum.Success)
					{
						return Redirect("/Setup/LetterHead/LetterHeadView");
					}
					else if (a == MennsageEnum.Duplicate)
					{
						ModelState.AddModelError("", "LetterHead Already Exists");
					}
					else
					{
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _letterHeadService.LetterHeadUpdate(letterHeadDTO);
					if (a == MennsageEnum.Updated)
					{
						return Redirect("/Setup/LetterHead/LetterHeadView");
					}
					else if (a == MennsageEnum.Duplicate)
					{
						ModelState.AddModelError("", "LetterHead Already Exists");
					}
					else
					{
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}


			return View("~/Areas/Setup/Views/LetterHead/LetterHeadCreate.cshtml", letterHeadDTO);
		}
        public IActionResult LetterHeadView()
        {
            ViewBag.letterHeads = _letterHeadService.GetLetterHeads();

            return View("~/Areas/Setup/Views/LetterHead/LetterHeadView.cshtml");
        }
        public IActionResult LetterHeadDelete(int letterHeadId)
        {
            int DeletedBy = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _letterHeadService.LetterHeadDelete(letterHeadId, DeletedBy);
            return Redirect("/Setup/LetterHead/LetterHeadView");
        }
    }
}
