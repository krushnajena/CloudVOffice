using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;

using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public class RestrictedWebsiteService : IRestrictedWebsiteService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<RestrictedWebsite> _restrictedWebsiteRepo;
        public RestrictedWebsiteService(ApplicationDBContext Context, ISqlRepository<RestrictedWebsite> restrictedWebsiteRepo)
        {

            _Context = Context;
            _restrictedWebsiteRepo = restrictedWebsiteRepo;
        }
        public MessageEnum RestrictedWebsiteCreate(RestrictedWebsiteDTO restrictedWebsiteDTO)
        {
            var objCheck = _Context.RestrictedWebsites.SingleOrDefault(opt => opt.RestrictedWebsiteName == restrictedWebsiteDTO.RestrictedWebsiteName && opt.Deleted == false);
            try
            {
                if (objCheck == null)
                {

                    RestrictedWebsite restrictedWebsite = new RestrictedWebsite();
                    restrictedWebsite.RestrictedWebsiteName = restrictedWebsiteDTO.RestrictedWebsiteName;
                    restrictedWebsite.DepartmentId = restrictedWebsiteDTO.DepartmentId;                  
                    restrictedWebsite.CreatedBy = restrictedWebsiteDTO.CreatedBy;
                    var obj = _restrictedWebsiteRepo.Insert(restrictedWebsite);

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
        public RestrictedWebsite GetRestrictedWebsiteByRestrictedWebsiteId(Int64 RestrictedWebsiteId)
        {
            try
            {
                return _Context.RestrictedWebsites.Where(x => x.RestrictedWebsiteId == RestrictedWebsiteId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public RestrictedWebsite GetRestrictedWebsiteByRestrictedWebsiteName(string restrictedWebsiteName)
        {
            try
            {
                return _Context.RestrictedWebsites.Where(x => x.RestrictedWebsiteName == restrictedWebsiteName && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<RestrictedWebsite> GetRestrictedWebsites()
        {
            try
            {
                return _Context.RestrictedWebsites.Where(x => x.Deleted == false).ToList();
            }
            catch
            {
                throw;
            }
        }

       

        public MessageEnum RestrictedWebsiteDelete(Int64 RestrictedWebsiteId, Int64 DeletedBy)
        {

            try
            {
                var a = _Context.RestrictedWebsites.Where(x => x.RestrictedWebsiteId == RestrictedWebsiteId).FirstOrDefault();
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

        public MessageEnum RestrictedWebsiteUpdate(RestrictedWebsiteDTO restrictedWebsiteDTO)
        {
            try
            {
                var restrictedWebsite = _Context.RestrictedWebsites.Where(x => x.RestrictedWebsiteId != restrictedWebsiteDTO.RestrictedWebsiteId && x.RestrictedWebsiteName == restrictedWebsiteDTO.RestrictedWebsiteName && x.Deleted == false).FirstOrDefault();
                if (restrictedWebsite == null)
                {
                    var a = _Context.RestrictedWebsites.Where(x => x.RestrictedWebsiteId == restrictedWebsiteDTO.RestrictedWebsiteId).FirstOrDefault();
                    if (a != null)
                    {
                        a.RestrictedWebsiteName = restrictedWebsiteDTO.RestrictedWebsiteName;
                        a.DepartmentId = restrictedWebsiteDTO.DepartmentId;
                      
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
