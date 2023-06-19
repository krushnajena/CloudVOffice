using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Accounts;
using CloudVOffice.Services.Accounts;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Accounts.Base.Controllers
{
	[Area(AreaNames.Accounts)]
    public class ChartOfAccountsController : BasePluginController
	{
		private readonly IChartOfAccountsServices _chartOfAccountsService;
		public ChartOfAccountsController(IChartOfAccountsServices ChartOfAccountsService)
		{

			_chartOfAccountsService = ChartOfAccountsService;
		}
		[HttpGet]
		public IActionResult ChartOfAccountsCreate(int? chartOfAccountsId)
		{
			ChartOfAccountsDTO chartOfAccountsDTO = new ChartOfAccountsDTO();
			var chartOfAccounts = _chartOfAccountsService.GetChartOfAccounts();
			ViewBag.ParentAccountGroup = chartOfAccounts;
			if (chartOfAccountsId != null)
			{

				var d = _chartOfAccountsService.GetChartOfAccountsById(int.Parse(chartOfAccountsId.ToString()));
				
				chartOfAccountsDTO.AccountName = d.AccountName;
				chartOfAccountsDTO.AccountNumber = d.AccountNumber;
				chartOfAccountsDTO.IsGroup = d.IsGroup;
				chartOfAccountsDTO.RootType = d.RootType;
				chartOfAccountsDTO.ReportType = d.ReportType;
				chartOfAccountsDTO.ParentAccountGroupId = d.ParentAccountGroupId;
				chartOfAccountsDTO.AccountType = d.AccountType;
				chartOfAccountsDTO.TaxRate = d.TaxRate;
				chartOfAccountsDTO.BalanceMustBe = d.BalanceMustBe;


			}

			return View("~/Plugins/Accounts.Base/Views/ChartOfAccounts/ChartOfAccountsCreate.cshtml", chartOfAccountsDTO);

		}
        [HttpPost]			
        public IActionResult ChartOfAccountsCreate(ChartOfAccountsDTO chartOfAccountsDTO)

		{

			chartOfAccountsDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


			if (ModelState.IsValid)
			{
				if (chartOfAccountsDTO.ChartOfAccountsId == null)
				{
					var a = _chartOfAccountsService.CreateChartOfAccounts(chartOfAccountsDTO);
					if (a == MessageEnum.Success)
					{
						TempData["msg"] = MessageEnum.Success;
						return Redirect("/Accounts/ChartOfAccounts/ChartOfAccountsView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "ChartOfAccounts Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _chartOfAccountsService.ChartOfAccountsUpdate(chartOfAccountsDTO);
					if (a == MessageEnum.Updated)
					{
						TempData["msg"] = MessageEnum.Updated;
						return Redirect("/Accounts/ChartOfAccounts/ChartOfAccountsView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "ChartOfAccounts Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}
			var parentAccountGroup = _chartOfAccountsService.GetChartOfAccounts();
			ViewBag.ParentAccountGroup = parentAccountGroup;
			return View("~/Plugins/Accounts.Base/Views/ChartOfAccounts/ChartOfAccountsCreate.cshtml", chartOfAccountsDTO);
		}
		public IActionResult ChartOfAccountsView()
		{
			ViewBag.ChartOfAccounts = _chartOfAccountsService.GetChartOfAccounts();

			return View("~/Plugins/Accounts.Base/Views/ChartOfAccounts/ChartOfAccountsView.cshtml");
		}

		[HttpGet]

		public IActionResult ChartOfAccountsDelete(int chartOfAccountsId)
		{
			Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			var a = _chartOfAccountsService.ChartOfAccountsDelete(chartOfAccountsId, DeletedBy);
			TempData["msg"] = a;
			return Redirect("/Accounts/ChartOfAccounts/ChartOfAccountsView");
		}
	}
}
