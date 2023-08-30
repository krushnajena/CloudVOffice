using CloudVOffice.Core.Domain.Accounts;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Data.DTO.Accounts;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace CloudVOffice.Services.Accounts
{
    public class ChartOfAccountsService : IChartOfAccountsServices
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<ChartOfAccounts> _chartOfAccountsRepo;

        public ChartOfAccountsService(ApplicationDBContext Context, ISqlRepository<ChartOfAccounts> chartOfAccountsRepo)
        {

            _Context = Context;
            _chartOfAccountsRepo = chartOfAccountsRepo;
        }

        public MessageEnum ChartOfAccountsDelete(Int64 chartOfAccountsId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.ChartOfAccounts.Where(x => x.ChartOfAccountsId == chartOfAccountsId).FirstOrDefault();
                if (a != null)
                {
                    a.Deleted = true;
                    a.UpdatedBy = DeletedBy;
                    a.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();
                    return MessageEnum.Deleted;
                }
                else
                    return MessageEnum.Invalid;
            }
            catch
            {
                throw;
            }
        }


        public MessageEnum ChartOfAccountsUpdate(ChartOfAccountsDTO chartOfAccountsDTO)
        {
            try
            {
                var ChartOfAccount = _Context.ChartOfAccounts.Where(x => x.ChartOfAccountsId != chartOfAccountsDTO.ChartOfAccountsId && x.AccountName == chartOfAccountsDTO.AccountName && x.Deleted == false).FirstOrDefault();
                if (ChartOfAccount == null)
                {
                    var a = _Context.ChartOfAccounts.Where(x => x.ChartOfAccountsId == chartOfAccountsDTO.ChartOfAccountsId).FirstOrDefault();
                    if (a != null)
                    {
                        a.AccountName = chartOfAccountsDTO.AccountName;
                        a.AccountNumber = chartOfAccountsDTO.AccountNumber;
                        a.IsGroup = chartOfAccountsDTO.IsGroup;
                        a.RootType = chartOfAccountsDTO.RootType;
                        a.ReportType = chartOfAccountsDTO.ReportType;
                        a.ParentAccountGroupId = chartOfAccountsDTO.ParentAccountGroupId;
                        a.AccountType = chartOfAccountsDTO.AccountType;
                        a.TaxRate = chartOfAccountsDTO.TaxRate;
                        a.BalanceMustBe = chartOfAccountsDTO.BalanceMustBe;
                        a.UpdatedBy = chartOfAccountsDTO.CreatedBy;
                        a.UpdatedDate = DateTime.Now;
                        _Context.SaveChanges();
                        return MessageEnum.Updated;
                    }
                    else
                        return MessageEnum.Invalid;
                }
                else
                {
                    return MessageEnum.Duplicate;
                }

            }
            catch
            {
                throw;
            }
        }

        public MessageEnum CreateChartOfAccounts(ChartOfAccountsDTO chartOfAccountsDTO)
        {


            var objCheck = _Context.ChartOfAccounts.SingleOrDefault(opt => opt.ChartOfAccountsId == chartOfAccountsDTO.ChartOfAccountsId && opt.Deleted == false);
            try
            {
                if (objCheck == null)
                {

                    ChartOfAccounts chartOfAccounts = new ChartOfAccounts();
                    chartOfAccounts.AccountName = chartOfAccountsDTO.AccountName;
                    chartOfAccounts.AccountNumber = chartOfAccountsDTO.AccountNumber;
                    chartOfAccounts.IsGroup = chartOfAccountsDTO.IsGroup;
                    chartOfAccounts.RootType = chartOfAccountsDTO.RootType;
                    chartOfAccounts.ReportType = chartOfAccountsDTO.ReportType;
                    chartOfAccounts.ParentAccountGroupId = chartOfAccountsDTO.ParentAccountGroupId;
                    chartOfAccounts.AccountType = chartOfAccountsDTO.AccountType;
                    chartOfAccounts.TaxRate = chartOfAccountsDTO.TaxRate;
                    chartOfAccounts.BalanceMustBe = chartOfAccountsDTO.BalanceMustBe;
                    chartOfAccounts.CreatedBy = chartOfAccountsDTO.CreatedBy;
                    var obj = _chartOfAccountsRepo.Insert(chartOfAccounts);

                    return MessageEnum.Success;
                }
                else if (objCheck != null)
                {
                    return MessageEnum.Duplicate;
                }

                return MessageEnum.UnExpectedError;
            }
            catch
            {
                throw;
            }
        }

        public List<ChartOfAccounts> GetChartOfAccounts()
        {

            try
            {

                var chartOfAccounts = new List<ChartOfAccounts>();
              
                var c= _Context.ChartOfAccounts.Where(x=>x.ParentAccountGroupId == null && x.Deleted == false).ToList();


                foreach (var nemployee in c)
                {
                   
                    List<ChartOfAccounts> cr= GetSubChartOfAccounts(nemployee.ChartOfAccountsId);
                    nemployee.Subordinates = cr;
                    chartOfAccounts.Add(nemployee);
                }


                return chartOfAccounts;
            }
            catch
            {
                throw;
            }
        }



        private List<ChartOfAccounts> GetSubChartOfAccounts(long AccountsId)
        {
            var chartOfAccounts = new List<ChartOfAccounts>();
            //result.Add(employee);
            var employees = _Context.ChartOfAccounts
               
                .Where(e => e.ParentAccountGroupId == AccountsId && e.Deleted == false)
                .ToList();


            foreach (var nemployee in employees)
            {

                List<ChartOfAccounts> cr = GetSubChartOfAccounts(nemployee.ChartOfAccountsId);
                nemployee.Subordinates = cr;
                chartOfAccounts.Add(nemployee);
            }

            return chartOfAccounts;
        }

        public ChartOfAccounts GetChartOfAccountsById(Int64 chartOfAccountsId)
        {
            try
            {
                return _Context.ChartOfAccounts.Where(x => x.ChartOfAccountsId == chartOfAccountsId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }


    }
}
