using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;

namespace CloudVOffice.Services.HR.Master
{
    public class EmployeeGradeService : IEmployeeGradeServices
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<EmployeeGrade> _employeeGradeRepo;
        public EmployeeGradeService(ApplicationDBContext Context, ISqlRepository<EmployeeGrade> employeeGradeRepo)
        {

            _Context = Context;
            _employeeGradeRepo = employeeGradeRepo;
        }
        public MessageEnum CreateEmployeeGrade(EmployeeGradeDTO employeeGradeDTO)
        {
            try
            {
                var employeeGrade = _Context.EmployeeGrades.Where(x => x.EmployeeGradeName == employeeGradeDTO.EmployeeGradeName && x.Deleted == false).FirstOrDefault();
                if (employeeGrade == null)
                {
                    _employeeGradeRepo.Insert(new EmployeeGrade()
                    {
                        EmployeeGradeName = employeeGradeDTO.EmployeeGradeName,

                        CreatedDate = DateTime.Now,
                        Deleted = false
                    });
                    return MessageEnum.Success;
                }
                else
                    return MessageEnum.Duplicate;
            }
            catch
            {
                throw;
            }

        }

        public MessageEnum EmployeeGradeDelete(Int64 employeeGradeId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.EmployeeGrades.Where(x => x.EmployeeGradeId == employeeGradeId).FirstOrDefault();
                if (a != null)
                {
                    a.Deleted = true;
                    a.UpdatedBy = DeletedBy;
                    a.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();
                    return MessageEnum.Deleted;
                }
                else
                    return MessageEnum.Invalid;
            }
            catch
            {
                throw;
            }
        }

        public MessageEnum EmployeeGradeUpdate(EmployeeGradeDTO employeeGradeDTO)
        {
            try
            {
                var employeeGrade = _Context.EmployeeGrades.Where(x => x.EmployeeGradeId != employeeGradeDTO.EmployeeGradeId && x.EmployeeGradeName == employeeGradeDTO.EmployeeGradeName && x.Deleted == false).FirstOrDefault();
                if (employeeGrade == null)
                {
                    var a = _Context.EmployeeGrades.Where(x => x.EmployeeGradeId == employeeGradeDTO.EmployeeGradeId).FirstOrDefault();
                    if (a != null)
                    {
                        a.EmployeeGradeName = employeeGradeDTO.EmployeeGradeName;

                        a.UpdatedDate = DateTime.Now;
                        _Context.SaveChanges();
                        return MessageEnum.Updated;
                    }
                    else
                        return MessageEnum.Invalid;
                }
                else
                {
                    return MessageEnum.Duplicate;
                }

            }
            catch
            {
                throw;
            }
        }

        public EmployeeGrade GetEmployeeGradeById(Int64 employeeGradeId)
        {
            try
            {
                return _Context.EmployeeGrades.Where(x => x.EmployeeGradeId == employeeGradeId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<EmployeeGrade> GetEmployeeGradeList()
        {
            try
            {
                return _Context.EmployeeGrades.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }
    }

}
