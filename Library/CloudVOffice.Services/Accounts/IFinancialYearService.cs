using CloudVOffice.Core.Domain.Accounts;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.Accounts;
using CloudVOffice.Data.DTO.HR.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Accounts
{
    public interface IFinancialYearService
    {
        public MessageEnum CreateFinancialYear(FinancialYearDTO financialYearDTO);
        public List<FinancialYear> GetFinancialYearList();
		public FinancialYear GetFinancialYearByFinancialYearId(Int64 financialYearId);
		public FinancialYear GetFinancialYearByName( string financialYearName);
        public MessageEnum FinancialYearUpdate(FinancialYearDTO financialYearDTO);
        public MessageEnum FinancialYearDelete(Int64 financialYearId, Int64 DeletedBy);

    }
}
