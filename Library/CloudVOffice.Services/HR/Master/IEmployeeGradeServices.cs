using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.HR.Master
{
    public interface IEmployeeGradeServices
    {
        public MessageEnum CreateEmployeeGrade(EmployeeGradeDTO employeeGradeDTO);
        public List<EmployeeGrade> GetEmployeeGradeList();
        public EmployeeGrade GetEmployeeGradeById(Int64 employeeGradeId);
        public MessageEnum EmployeeGradeUpdate(EmployeeGradeDTO employeeGradeDTO);
        public MessageEnum EmployeeGradeDelete(Int64 employeeGradeId, Int64 DeletedBy);
    }
}
