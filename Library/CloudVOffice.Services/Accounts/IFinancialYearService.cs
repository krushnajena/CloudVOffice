using CloudVOffice.Core.Domain.Accounts;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Accounts;

namespace CloudVOffice.Services.Accounts
{
    public interface IFinancialYearService
    {
        public MessageEnum CreateFinancialYear(FinancialYearDTO financialYearDTO);
        public List<FinancialYear> GetFinancialYearList();
        public FinancialYear GetFinancialYearByFinancialYearId(Int64 financialYearId);
        public FinancialYear GetFinancialYearByName(string financialYearName);
        public MessageEnum FinancialYearUpdate(FinancialYearDTO financialYearDTO);
        public MessageEnum FinancialYearDelete(Int64 financialYearId, Int64 DeletedBy);

    }
}
