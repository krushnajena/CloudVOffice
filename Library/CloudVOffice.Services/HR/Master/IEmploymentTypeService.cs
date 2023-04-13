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
    public interface IEmploymentTypeService
    {
        public MennsageEnum EmployementTypeCreate(EmploymentTypeDTO employmenttypeDTO);
        public List<EmploymentType> GetEmploymentTypes();
        public EmploymentType GetEmploymentTypeByEmploymentTypeId(Int64 employmenttypeId);
        public EmploymentType GetEmploymentTypeByEmploymentTypeName(string employmentTypeName);
        public MennsageEnum EmploymentTypeUpdate(EmploymentTypeDTO employmenttypeDTO);
        public MennsageEnum EmploymentTypeDelete(Int64 employmenttypeId, Int64 DeletedBy);
    }
}
