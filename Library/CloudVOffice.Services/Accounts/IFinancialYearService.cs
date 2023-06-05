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
		public FinancialYear GetFinancialYearByFinancialYearId(int financialYearId);
		public FinancialYear GetFinancialYearByName( string financialYearName);
        public MessageEnum FinancialYearUpdate(FinancialYearDTO financialYearDTO);
        public MessageEnum FinancialYearDelete(int financialYearId, Int64 DeletedBy);

    }
}
