using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace CloudVOffice.Services.Attendance
{
    public class LeavePeriodService : ILeavePeriodService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<LeavePeriod> _leavePeriodRepo;
        
        public LeavePeriodService(ApplicationDBContext Context, ISqlRepository<LeavePeriod> leavePeriodRepo)
        {

            _Context = Context;
            _leavePeriodRepo = leavePeriodRepo;
           
        }
        public MessageEnum CreateLeavePeriod(LeavePeriodDTO leavePeriodDTO)
        {
            try
            {
                var LeavePeriod = _Context.LeavePeriods.Where(x => x.LeavePeriodId == leavePeriodDTO.LeavePeriodId && x.Deleted == false).FirstOrDefault();
                if (LeavePeriod == null)
                {
                    _leavePeriodRepo.Insert(new LeavePeriod()
                    {
                        FromDate = leavePeriodDTO.FromDate,
                        ToDate = leavePeriodDTO.ToDate,
                        CreatedBy = leavePeriodDTO.CreatedBy,
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

        public LeavePeriod GetLeavePeriodById(int leavePeriodId)
        {
            try
            {
                return _Context.LeavePeriods.Where(x => x.LeavePeriodId == leavePeriodId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<LeavePeriod> GetLeavePeriodList()
        {
            try
            {
                return _Context.LeavePeriods.Where(x => x.Deleted == false).ToList();



            }
            catch
            {
                throw;
            }
        }

        public MessageEnum LeavePeriodDelete(int leavePeriodId, int DeletedBy)
        {
            try
            {
                var a = _Context.LeavePeriods.Where(x => x.LeavePeriodId == leavePeriodId).FirstOrDefault();
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

        
        public MessageEnum LeavePeriodUpdate(LeavePeriodDTO leavePeriodDTO)
        {
            try
            {
                var leavePeriod = _Context.LeavePeriods.Where(x => x.LeavePeriodId != leavePeriodDTO.LeavePeriodId && x.LeavePeriodId == leavePeriodDTO.LeavePeriodId && x.Deleted == false).FirstOrDefault();
                if (leavePeriod == null)
                {
                    var a = _Context.LeavePeriods.Where(x => x.LeavePeriodId == leavePeriodDTO.LeavePeriodId).FirstOrDefault();
                    if (a != null)
                    {
                        a.FromDate = leavePeriodDTO.FromDate;
                        a.ToDate = leavePeriodDTO.ToDate;
                        a.UpdatedBy = leavePeriodDTO.CreatedBy;
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
        public bool LeavePeriodOverlap(DateTime? fromDate, DateTime? toDate, int? leavePeriodId = null)
        {

            var existingLeavePeriods = GetLeavePeriodList();

            if (leavePeriodId.HasValue)
            {
                existingLeavePeriods = existingLeavePeriods
                    .Where(lp => lp.LeavePeriodId != leavePeriodId)
                    .ToList();
            }

            return existingLeavePeriods.Any(lp =>
                (fromDate >= lp.FromDate && fromDate <= lp.ToDate) ||
                (toDate >= lp.FromDate && toDate <= lp.ToDate) ||
                (fromDate <= lp.FromDate && toDate >= lp.ToDate)
            );

        }
    }
}

    

