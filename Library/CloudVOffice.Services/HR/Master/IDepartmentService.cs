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
        public MennsageEnum CreateDepartment(DepartmentDTO departmentDTO);
        public List<Department> GetDepartmentList();
        public Department GetDepartmentById(Int64 departmentId);
        public MennsageEnum DepartmentUpdate(DepartmentDTO departmentDTO);
        public MennsageEnum DepartmentDelete(Int64 deprtmentid, Int64 DeletedBy);
        public List<Department> GetAllDepartmentGroups(); 
    }
}
