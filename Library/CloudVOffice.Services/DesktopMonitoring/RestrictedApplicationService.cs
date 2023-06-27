using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Data.Migrations;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public class RestrictedApplicationService : IRestrictedApplicationService
    {
        public readonly ApplicationDBContext _Context;
        public readonly ISqlRepository<RestrictedApplication> _restrictedApplicationRepo;

        public RestrictedApplicationService(ApplicationDBContext Context, ISqlRepository<RestrictedApplication> restrictedApplicationRepo)
        {
            _Context = Context;
            _restrictedApplicationRepo = restrictedApplicationRepo;
        }
        public MessageEnum RestrictedApplicationCreate(RestrictedApplicationDTO restrictedApplicationDTO)
        {
            var objCheck = _Context.RestrictedApplications.SingleOrDefault(opt => opt.RestrictedApplicationName == restrictedApplicationDTO.RestrictedApplicationName && opt.Deleted == false);
            try
            {
                if (objCheck == null)
                {

                    RestrictedApplication restrictedApplication = new RestrictedApplication();
                    restrictedApplication.RestrictedApplicationName = restrictedApplicationDTO.RestrictedApplicationName;
                    restrictedApplication.DepartmentId = restrictedApplicationDTO.DepartmentId;
                    restrictedApplication.CreatedBy = restrictedApplicationDTO.CreatedBy;                 
                    var obj = _restrictedApplicationRepo.Insert(restrictedApplication);

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
        public List<RestrictedApplication> GetRestrictedApplication()
        {
            try
            {
                return _Context.RestrictedApplications.Where(x => x.Deleted == false).ToList();
            }
            catch
            {
                throw;
            }
        }
        public RestrictedApplication GetRestrictedApplicationById(Int64 RestrictedApplicationId)
        {
            try
            {
                return _Context.RestrictedApplications.Where(x => x.RestrictedApplicationId == RestrictedApplicationId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }
        public MessageEnum RestrictedApplicationDelete(Int64 RestrictedApplicationId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.RestrictedApplications.Where(x => x.RestrictedApplicationId == RestrictedApplicationId).FirstOrDefault();
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

        public MessageEnum RestrictedApplicationUpdate(RestrictedApplicationDTO restrictedApplicationDTO)
        {
            try
            {
                var restrictedApplication = _Context.RestrictedApplications.Where(x => x.RestrictedApplicationId != restrictedApplicationDTO.RestrictedApplicationId && x.RestrictedApplicationName == restrictedApplicationDTO.RestrictedApplicationName && x.Deleted == false).FirstOrDefault();
                if (restrictedApplication == null)
                {
                    var a = _Context.RestrictedApplications.Where(x => x.RestrictedApplicationId == restrictedApplicationDTO.RestrictedApplicationId).FirstOrDefault();
                    if (a != null)
                    {
                        a.RestrictedApplicationName = restrictedApplicationDTO.RestrictedApplicationName;
                        a.DepartmentId = restrictedApplicationDTO.DepartmentId;

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
