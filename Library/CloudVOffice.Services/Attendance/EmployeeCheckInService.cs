using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;

namespace CloudVOffice.Services.Attendance
{
    public class EmployeeCheckInService : IEmployeeCheckInService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<EmployeeCheckIn> _employeeCheckInRepo;

        public EmployeeCheckInService(ApplicationDBContext Context, ISqlRepository<EmployeeCheckIn> employeeCheckInRepo)
        {

            _Context = Context;
            _employeeCheckInRepo = employeeCheckInRepo;
        }
        public MessageEnum EmployeeCheckInCreate(EmployeeCheckInDTO employeeCheckInDTO)
        {
            var objCheck = _Context.EmployeeCheckIns.SingleOrDefault(opt => opt.EmployeeCheckInId == employeeCheckInDTO.EmployeeCheckInId && opt.Deleted == false);
            try
            {
                if (objCheck == null)
                {

                    EmployeeCheckIn employeeCheckIn = new EmployeeCheckIn();
                    employeeCheckIn.EmployeeId = employeeCheckInDTO.EmployeeId;
                    employeeCheckIn.ForDate = employeeCheckInDTO.ForDate;
                    employeeCheckIn.LogType = employeeCheckInDTO.LogType;
                    employeeCheckIn.DeviceId = employeeCheckInDTO.DeviceId;                 
                    employeeCheckIn.CreatedBy = employeeCheckInDTO.CreatedBy;
                    var obj = _employeeCheckInRepo.Insert(employeeCheckIn);

                    return MessageEnum.Success;
                }
                else if (objCheck != null)
                {
                    return MessageEnum.Duplicate;
                }

                return MessageEnum.UnExpectedError;
            }
            catch
            {
                throw;
            }
        }

        public MessageEnum EmployeeCheckInDelete(Int64 employeeCheckInId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.EmployeeCheckIns.Where(x => x.EmployeeCheckInId == employeeCheckInId).FirstOrDefault();
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

        public MessageEnum EmployeeCheckInUpdate(EmployeeCheckInDTO employeeCheckInDTO)
        {
            try
            {
                var employeeCheckIn = _Context.EmployeeCheckIns.Where(x => x.EmployeeCheckInId != employeeCheckInDTO.EmployeeCheckInId && x.Deleted == false).FirstOrDefault();
                if (employeeCheckIn == null)
                {
                    var a = _Context.EmployeeCheckIns.Where(x => x.EmployeeCheckInId == employeeCheckInDTO.EmployeeCheckInId).FirstOrDefault();
                    if (a != null)
                    {
                        a.EmployeeId = employeeCheckInDTO.EmployeeId;
                        a.ForDate = employeeCheckInDTO.ForDate;
                        a.LogType = employeeCheckInDTO.LogType;
                        a.DeviceId = employeeCheckInDTO.DeviceId;
                        a.UpdatedBy = employeeCheckInDTO.CreatedBy;
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

        public List<EmployeeCheckIn> GetEmployeeCheckIn()
        {
            try
            {
                return _Context.EmployeeCheckIns.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public EmployeeCheckIn GetEmployeeCheckInById(Int64 employeeCheckInId)
        {
            try
            {
                return _Context.EmployeeCheckIns.Where(x => x.EmployeeCheckInId == employeeCheckInId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }
    }
}
