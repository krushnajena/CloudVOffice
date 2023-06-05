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
        public MessageEnum CreateFinancialYear(FinancialYearDTO FinancialYearDTO);
        public List<FinancialYear> GetFinancialYearList();
		public FinancialYear GetFinancialYearByFinancialYearId(int FinancialYearId);
		public FinancialYear GetFinancialYearByName( string FinancialYearName);
        public MessageEnum FinancialYearUpdate(FinancialYearDTO FinancialYearDTO);
        public MessageEnum FinancialYearDelete(int FinancialYearId, Int64 DeletedBy);

    }
}
