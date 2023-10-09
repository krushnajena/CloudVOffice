using Azure.Storage.Blobs.Models;
using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.AspNetCore.Http.HttpResults;

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

        public MessageEnum GetEmployeeCheckInUpdate(Int64 EmployeeId, DateTime ForDate,TimeSpan CheckInTime,TimeSpan CheckOutTime)
        {
            try
            {
                
                    EmployeeCheckIn employeeCheckIn1 = new EmployeeCheckIn();
                    employeeCheckIn1.EmployeeId = EmployeeId;
                    employeeCheckIn1.ForDate = ForDate + CheckInTime;
                    employeeCheckIn1.LogType = 1;    
                    var obj1 =_employeeCheckInRepo.Insert(employeeCheckIn1);               

                    EmployeeCheckIn employeeCheckIn2 = new EmployeeCheckIn();
                    employeeCheckIn2.EmployeeId = EmployeeId;
                    employeeCheckIn2.ForDate = ForDate + CheckOutTime;
                    employeeCheckIn2.LogType = 2;
                    var obj2 = _employeeCheckInRepo.Insert(employeeCheckIn2);
                    return MessageEnum.Success;

                
               
                return MessageEnum.Invalid;

            }
            catch
            {
                throw;
            }
        }
    }
}
