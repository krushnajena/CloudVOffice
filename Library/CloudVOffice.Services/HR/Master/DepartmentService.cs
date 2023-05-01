using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using LinqToDB;
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
        public MennsageEnum CreateDepartment(DepartmentDTO departmentDTO)
        {
            try
            {
                var department = _dbContext.Departments.Where(x => x.DepartmentName == departmentDTO.DepartmentName && x.Deleted == false && x.Parent== (departmentDTO.Parent == 0 ? null : departmentDTO.Parent)).FirstOrDefault();
                if (department == null)
                {
                    _departmentRepo.Insert(new Department()
                    {
                        DepartmentName = departmentDTO.DepartmentName,

                        Parent = departmentDTO.Parent == 0 ? null : departmentDTO.Parent,
                        IsGroup = departmentDTO.IsGroup,
                        CreatedBy = departmentDTO.CreatedBy,
                        CreatedDate = DateTime.Now,
                        Deleted = false,
                    });
                    return MennsageEnum.Success;
                }
                else return MennsageEnum.Duplicate;
            }
            catch
            {
                throw;
            }
        }

        public MennsageEnum DepartmentDelete(Int64 deprtmentid, Int64 DeletedBy)
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
                    return MennsageEnum.Deleted;
                }
                else
                    return MennsageEnum.Invalid;
            }
            catch
            {
                throw;
            }
        }

        public MennsageEnum DepartmentUpdate(DepartmentDTO departmentDTO)
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
                        return MennsageEnum.Updated;
                    }
                    else
                        return MennsageEnum.Invalid;
                }
                else
                {
                    return MennsageEnum.Duplicate;
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

        public Department GetDepartmentById(Int64 departmentId)
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

				var query = from c1 in _dbContext.Departments
							from c2 in _dbContext.Departments
							where c1.Parent == null
							where c1.Parent == c2.DepartmentId
							select c2;

				var crossSellProducts =  query.ToList();
                return crossSellProducts;
				



			}
            catch
            {
                throw;
            }
        }
    }
}
