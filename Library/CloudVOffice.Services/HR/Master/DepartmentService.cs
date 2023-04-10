using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.HR.Master
{
    public class DepartmentService : IDepartmentService
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly ISqlRepository<Department> _departmentRepo;
        public DepartmentService(ApplicationDBContext dbContext, ISqlRepository<Department> departmentRepo)
        {

            _dbContext = dbContext;
            _departmentRepo = departmentRepo;
        }
        public string CreateDepartment(DepartmentDTO departmentDTO)
        {
            try
            {
                var department = _dbContext.Departments.Where(x => x.DepartmentName == departmentDTO.DepartmentName && x.Deleted == false && x.Parent==departmentDTO.Parent);
                if (department == null)
                {
                    _departmentRepo.Insert(new Department()
                    {
                        DepartmentName = departmentDTO.DepartmentName,
                  
                        Parent = departmentDTO.Parent ==0 ? null : departmentDTO.Parent,
                        IsGroup = departmentDTO.IsGroup,
                        CreatedBy = departmentDTO.CreatedBy,
                        CreatedDate = DateTime.Now,
                        Deleted = false,
                    });
                    return "Success";
                }
                else return "duplicate";
            }
            catch
            {
                throw;
            }
        }

        public string DepartmentDelete(int deprtmentid, int DeletedBy)
        {
            try
            {
                var a = _dbContext.Departments.Where(x => x.DepartmentId == deprtmentid).FirstOrDefault();
                if (a != null)
                {
                    a.Deleted = true;
                    a.UpdatedBy = DeletedBy;
                    a.UpdatedDate = DateTime.Now;
                    _dbContext.SaveChanges();
                    return "deleted";
                }
                else
                    return "invalid";
            }
            catch
            {
                throw;
            }
        }

        public string DepartmentUpdate(DepartmentDTO departmentDTO)
        {

            try
            {
                var department = _dbContext.Departments.Where(x => x.DepartmentId != departmentDTO.DepartmentId && x.DepartmentName == departmentDTO.DepartmentName && x.Deleted == false & x.Parent==departmentDTO.Parent).FirstOrDefault();
                if (department == null)
                {
                    var a = _dbContext.Departments.Where(x => x.DepartmentId == departmentDTO.DepartmentId).FirstOrDefault();
                    if (a != null)
                    {
                        a.DepartmentName = departmentDTO.DepartmentName;
                        a.Parent = departmentDTO.Parent==0? null: departmentDTO.Parent;
                        a.IsGroup = departmentDTO.IsGroup;
                        a.UpdatedBy = departmentDTO.CreatedBy;
                        a.UpdatedDate = DateTime.Now;
                        _dbContext.SaveChanges();
                        return "delete";
                    }
                    else
                        return "invalid";
                }
                else
                {
                    return "duplicate";
                }
            }
            catch
            {
                throw;
            }
        }

        public List<Department> GetAllDepartmentGroups()
        {
            try
            {
                var a = _dbContext.Departments.Where(x => x.IsGroup == true && x.Deleted == false).ToList();
                a.Insert(0, new Department()
                {
                    DepartmentName = "Primary",
                    Deleted = false,
                    DepartmentId = 0,
                    Parent = null,
                    CreatedBy = 1,
                    CreatedDate = DateTime.Now
                });
                return a;

            }
            catch
            {
                throw;
            }
        }

        public Department GetDepartmentById(int departmentId)
        {
            try
            {
                return _dbContext.Departments.Where(x => x.DepartmentId == departmentId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<Department> GetDepartmentList()
        {
            try
            {
                return _dbContext.Departments.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }
    }
}
