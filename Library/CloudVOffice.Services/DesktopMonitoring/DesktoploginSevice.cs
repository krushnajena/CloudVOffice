using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.CodeAnalysis.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public class DesktoploginSevice : IDesktoploginSevice
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<DesktopLogin> _desktopLoginRepo;
        public DesktoploginSevice(ApplicationDBContext Context, ISqlRepository<DesktopLogin> desktopLoginRepo)
        {

            _Context = Context;
            _desktopLoginRepo = desktopLoginRepo;
        }
        public MennsageEnum DesktoploginCreate(DesktopLoginDTO desktoploginDTO)
        {
            try
            {
                var desktoplogincreate = _Context.DesktopLogins.Where(x => x.EmployeeId == desktoploginDTO.EmployeeId && x.Deleted == false).FirstOrDefault();
                if (desktoplogincreate == null)
                {
                    _desktopLoginRepo.Insert(new DesktopLogin()
                    {
                        EmployeeId = desktoploginDTO.EmployeeId,
                        LoginDateTime=desktoploginDTO.LoginDateTime,
                        LogOutDateTime=desktoploginDTO.LogOutDateTime,
                        IsAutoLogedOut=desktoploginDTO.IsAutoLogedOut,                       
                        IsActiveSession=false,
                        SyncedOn=desktoploginDTO.SyncedOn,
                        CreatedBy = desktoploginDTO.CreatedBy,
                        CreatedDate = DateTime.Now,
                        Deleted = false
                    });
                    return MennsageEnum.Success;
                }
                else
                    return MennsageEnum.Duplicate;
            }
            catch
            {
                throw;
            }
        }

        public MennsageEnum DesktopLoginDelete(Int64 DesktopLoginId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.DesktopLogins.Where(x => x.DesktopLoginId == DesktopLoginId).FirstOrDefault();
                if (a != null)
                {
                    a.Deleted = true;
                    a.UpdatedBy = DeletedBy;
                    a.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();
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

        public MennsageEnum DesktopLoginUpdate(DesktopLoginDTO desktoploginDTO)
        {
            try
            {
                var desktopLogin = _Context.DesktopLogins.Where(x => x.DesktopLoginId != desktoploginDTO.DesktopLoginId && x.EmployeeId == desktoploginDTO.EmployeeId && x.Deleted == false).FirstOrDefault();
                if (desktopLogin == null)
                {
                    var a = _Context.DesktopLogins.Where(x => x.DesktopLoginId == desktoploginDTO.DesktopLoginId).FirstOrDefault();
                    if (a != null)
                    {
                        a.EmployeeId = desktoploginDTO.EmployeeId;
                        a.LoginDateTime=desktoploginDTO.LoginDateTime;
                        a.LogOutDateTime=desktoploginDTO.LogOutDateTime;
                        a.IsActiveSession=desktoploginDTO.IsActiveSession;
                        a.IsAutoLogedOut=desktoploginDTO.IsAutoLogedOut;
                        a.SyncedOn=desktoploginDTO.SyncedOn;
                        a.UpdatedBy = desktoploginDTO.CreatedBy;
                        a.UpdatedDate = DateTime.Now;
                        _Context.SaveChanges();
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

        public DesktopLogin GetDesktoploginByDesktoploginId(Int64 DesktopLoginId)
        {
            try
            {
                return _Context.DesktopLogins.Where(x => x.DesktopLoginId == DesktopLoginId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<DesktopLogin> GetDesktoplogins()
        {
            try
            {
                return _Context.DesktopLogins.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }
    }
}
