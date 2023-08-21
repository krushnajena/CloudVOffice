using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;

namespace CloudVOffice.Services.HR.Master
{
    public interface IEmploymentTypeService
    {
        public MessageEnum EmployementTypeCreate(EmploymentTypeDTO employmenttypeDTO);
        public List<EmploymentType> GetEmploymentTypes();
        public EmploymentType GetEmploymentTypeByEmploymentTypeId(Int64 employmenttypeId);
        public EmploymentType GetEmploymentTypeByEmploymentTypeName(string employmentTypeName);
        public MessageEnum EmploymentTypeUpdate(EmploymentTypeDTO employmenttypeDTO);
        public MessageEnum EmploymentTypeDelete(Int64 employmenttypeId, Int64 DeletedBy);
    }
}
