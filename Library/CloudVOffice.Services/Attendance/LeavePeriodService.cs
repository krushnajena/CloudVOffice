using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                var branch = _Context.LeavePeriods.Where(x => x.LeavePeriodId != leavePeriodDTO.LeavePeriodId && x.LeavePeriodId == leavePeriodDTO.LeavePeriodId && x.Deleted == false).FirstOrDefault();
                if (branch == null)
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
    }
}
