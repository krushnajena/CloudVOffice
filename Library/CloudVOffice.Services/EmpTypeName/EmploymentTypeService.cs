using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Services.Permissions;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.EmpTypeName
{
    
    public class EmploymentTypeService : IEmploymentTypeService
    {
        private readonly ApplicationDBContext _context;
        private readonly ISqlRepository<EmploymentType> _EmploymentTypeRepo;
        public EmploymentTypeService(ApplicationDBContext context, ISqlRepository<EmploymentType> EmploymentTypeRepo)
        {
            _context = context;
            _EmploymentTypeRepo = EmploymentTypeRepo;
           
        }

        

        public string InsertEmploymenttype(string employmentTypeName, int CreatedBy)
        {
         var objCheck = _context.EmploymentTypes.SingleOrDefault(opt => opt.EmploymentTypeName == employmentTypeName);
                try
                {
                    if (objCheck == null)
                    {

                    EmploymentType employmentType = new EmploymentType();
                    employmentType.EmploymentTypeName = employmentTypeName;
                    employmentType.CreatedBy= CreatedBy;
                        var obj = _EmploymentTypeRepo.Insert(employmentType);
                        return "EmploymentType Sucessfully Created";

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
        public List<EmploymentType> GetAllEmploymentType()
        {
            return _context.EmploymentTypes.Where(x => x.Deleted == false).ToList();
        }
        public EmploymentType GetEmploymentTypeinsingle(int employmentTypeId)
        {
            try
            {
                var SingleemploymentType = _EmploymentTypeRepo.SelectById(employmentTypeId);

                return SingleemploymentType;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public EmploymentType DeleteEmploymentType(int employmentTypeId)
        {
            try
            {
                var obj = _context.EmploymentTypes.SingleOrDefault(opt => opt.EmploymentTypeId == employmentTypeId);
                _context.SaveChanges();
                return obj;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public EmploymentType UpdateEmploymentType(int employmentTypeId, string employmentTypeName, int CreatedBy)
        {
            try
            {
                var objEmploymentType = _context.EmploymentTypes.SingleOrDefault(opt => opt.EmploymentTypeId == employmentTypeId);
                objEmploymentType.EmploymentTypeName = employmentTypeName;
                objEmploymentType.CreatedBy= CreatedBy;
                objEmploymentType.CreatedDate = DateTime.Now;
                _context.SaveChanges();
                return objEmploymentType;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

