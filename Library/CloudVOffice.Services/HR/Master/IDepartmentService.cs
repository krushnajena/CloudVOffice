using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;

namespace CloudVOffice.Services.HR.Master
{
    public interface IDepartmentService
    {
        public MessageEnum CreateDepartment(DepartmentDTO departmentDTO);
        public List<Department> GetDepartmentList();
        public Department GetDepartmentById(int departmentId);
        public MessageEnum DepartmentUpdate(DepartmentDTO departmentDTO);
        public MessageEnum DepartmentDelete(int deprtmentid, Int64 DeletedBy);
        public List<Department> GetAllDepartmentGroups();
    }
}
