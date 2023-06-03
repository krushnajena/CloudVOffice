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
    public interface IDepartmentService
    {
        public MessageEnum CreateDepartment(DepartmentDTO departmentDTO);
        public List<Department> GetDepartmentList();
        public Department GetDepartmentById(Int64 departmentId);
        public MessageEnum DepartmentUpdate(DepartmentDTO departmentDTO);
        public MessageEnum DepartmentDelete(Int64 deprtmentid, Int64 DeletedBy);
        public List<Department> GetAllDepartmentGroups(); 
    }
}
