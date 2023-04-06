<<<<<<< HEAD
﻿using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Services.Permissions;
using System;
=======
﻿/*using System;
>>>>>>> 63e417145321f95ac729f28508a02161f31ec0c3
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Departments
{
<<<<<<< HEAD
    public class DepartmentService : IDepartmentService
    {
        private readonly ApplicationDBContext _context;
        private readonly ISqlRepository<Department> _DepartmentRepo;
        public DepartmentService(ApplicationDBContext context, ISqlRepository<Department> DepartmentRepo)
        {
            _context = context;
            _DepartmentRepo = DepartmentRepo;

        }

        public List<Department> GetAllDepartment()
        {
            throw new NotImplementedException();
        }

        public string InsertDepartmentName(string departmentName, int CreatedBy)
        {

            var objCheck = _context.Departments.SingleOrDefault(opt => opt.DepartmentName == departmentName);
            try
            {
                if (objCheck == null)
                {

                    Department department = new Department();
                    department.DepartmentName = departmentName;
                    department.CreatedBy = CreatedBy;
                    var obj = _DepartmentRepo.Insert(department);
                    return "Department Sucessfully Created";

                }
                else if (objCheck != null)
                {
                    return "Duplicate";
                }

                return "Something unexpected!";
            }
            catch (Exception ex)
            {
                return "Error!";
            }
           
        }
        public List<Department> GetAllDepartments()
        {
            return _context.Departments.Where(x => x.Deleted == false).ToList();
        }
        public Department GetDepartmentinsingle(int departmentId)
        {
            try
            {
                var Singledepartment = _DepartmentRepo.SelectById(departmentId);

                return Singledepartment;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public Department UpdateDepartment(int departmentId, string departmentName, int CreatedBy)
        {
            try
            {
                var objDepartment = _context.Departments.SingleOrDefault(opt => opt.DepartmentId == departmentId);
                objDepartment.DepartmentName = departmentName;
                objDepartment.CreatedBy = CreatedBy;
                objDepartment.CreatedDate = DateTime.Now;
                _context.SaveChanges();
                return objDepartment;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Department DeleteDepartment(int departmentId)
        {
            try
            {
                var obj = _context.Departments.SingleOrDefault(opt => opt.DepartmentId == departmentId);
                _context.SaveChanges();
                return obj;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
=======
    public class DepartmentService
    {
    }
}
*/
>>>>>>> 63e417145321f95ac729f28508a02161f31ec0c3
