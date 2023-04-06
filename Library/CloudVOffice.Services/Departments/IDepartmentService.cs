using CloudVOffice.Core.Domain.HR.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Departments
{
    public interface IDepartmentService
    {
        public string InsertDepartmentName(string departmentName, int CreatedBy);
        public List<Department> GetAllDepartment();
         public Department GetDepartmentinsingle(int departmentId);
        public Department UpdateDepartment(int departmentId, string departmentName, int CreatedBy);
        public Department DeleteDepartment(int departmentId);
    }
}
