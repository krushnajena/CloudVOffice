using CloudVOffice.Core.Domain.Accounts;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Accounts;

namespace CloudVOffice.Services.Accounts
{
    public interface IChartOfAccountsServices
    {
        public MessageEnum CreateChartOfAccounts(ChartOfAccountsDTO chartOfAccountsDTO);
        public List<ChartOfAccounts> GetChartOfAccounts();
        public ChartOfAccounts GetChartOfAccountsById(Int64 chartOfAccountsId);

        public MessageEnum ChartOfAccountsUpdate(ChartOfAccountsDTO chartOfAccountsDTO);
        public MessageEnum ChartOfAccountsDelete(Int64 chartOfAccountsId, Int64 DeletedBy);
    }
}
