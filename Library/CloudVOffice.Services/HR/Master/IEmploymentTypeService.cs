using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.HR.Master
{
    public interface IEmploymentTypeService
    {
        public string EmployementTypeCreate(EmploymentTypeDTO employmenttypeDTO);
        public List<EmploymentType> GetEmploymentTypes();
        public EmploymentType GetEmploymentTypeByEmploymentTypeId(int employmenttypeId);
        public EmploymentType GetEmploymentTypeByEmploymentTypeName(string employmentTypeName);
        public string EmploymentTypeUpdate(EmploymentTypeDTO employmenttypeDTO);
        public string EmploymentTypeDelete(int employmenttypeId, int DeletedBy);
    }
}
