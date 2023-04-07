using CloudVOffice.Core.Domain.HR.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.EmpTypeName
{
    public interface IEmploymentTypeService
    {
        public string InsertEmploymenttype(string employmentTypeName, int CreatedBy);
        public List<EmploymentType> GetAllEmploymentType();
        public EmploymentType GetEmploymentTypeinsingle(int employmentTypeId);
        public EmploymentType UpdateEmploymentType(int employmentTypeId, string employmentTypeName, int CreatedBy);
        public EmploymentType DeleteEmploymentType(int employmentTypeId);
    }
}
