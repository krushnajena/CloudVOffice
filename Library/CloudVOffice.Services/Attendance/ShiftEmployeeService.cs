using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.DTO.Emp;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Services.Emp;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CloudVOffice.Services.Attendance
{
    public class ShiftEmployeeService : IShiftEmployeeService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<ShiftEmployee> _shiftEmployeeRepo;
        public ShiftEmployeeService(ApplicationDBContext Context, ISqlRepository<ShiftEmployee> shiftEmployeeRepo)
        {

            _Context = Context;
            _shiftEmployeeRepo = shiftEmployeeRepo;
            
        }
        public MessageEnum CreateShiftEmployee(ShiftEmployeeDTO shiftEmployeeDTO)
        {

            try
            {
                var EmployeeList = JsonConvert.DeserializeObject<List<EmployeeCreateDTO>>(shiftEmployeeDTO.EmployeesString);

                for (int i = 0; i < EmployeeList.Count; i++)
                {

                    ShiftEmployee shiftEmployee = new ShiftEmployee();
                    shiftEmployee.ShiftId = shiftEmployeeDTO.ShiftId;
                    shiftEmployee.CreatedBy = shiftEmployeeDTO.CreatedBy;
                    shiftEmployee.EmployeeId = EmployeeList[i].EmployeeId;
                    shiftEmployee.FromDate = shiftEmployeeDTO.FromDate;
                    shiftEmployee.ToDate = shiftEmployeeDTO.ToDate;
                    var obj = _shiftEmployeeRepo.Insert(shiftEmployee);
                }

                return MessageEnum.Success;
            }
            catch
            {
                throw;
            }
        }

        public List<ShiftEmployee> GetShiftEmployeeList()
        {
            try
            {
                return _Context.ShiftEmployees.Include(x => x.Employee).Include(x => x.ShiftType).Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public ShiftEmployee GetShiftEmployeeById(Int64 shiftEmployeeId)
        {
            try
            {
                return _Context.ShiftEmployees.Where(x => x.ShiftEmployeeId == shiftEmployeeId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public MessageEnum ShiftEmployeeDelete(Int64 shiftEmployeeId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.ShiftEmployees.Where(x => x.ShiftEmployeeId == shiftEmployeeId).FirstOrDefault();
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

        public MessageEnum ShiftEmployeeUpdate(ShiftEmployeeDTO shiftEmployeeDTO)
        {
            try
            {
                var shiftEmployee = _Context.ShiftEmployees.Where(x => x.ShiftEmployeeId != shiftEmployeeDTO.ShiftEmployeeId && x.Deleted == false).FirstOrDefault();
                if (shiftEmployee == null)
                {
                    var a = _Context.ShiftEmployees.Where(x => x.ShiftEmployeeId == shiftEmployeeDTO.ShiftEmployeeId).FirstOrDefault();
                    if (a != null)
                    {
                        a.ShiftId = shiftEmployeeDTO.ShiftId;
                        a.EmployeeId = shiftEmployeeDTO.EmployeeId;
                        a.FromDate = shiftEmployeeDTO.FromDate;
                        a.ToDate = shiftEmployeeDTO.ToDate;
                        a.UpdatedBy = shiftEmployeeDTO.CreatedBy;
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
    }
}
