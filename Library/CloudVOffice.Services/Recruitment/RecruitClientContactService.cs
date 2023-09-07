using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment
{
    public class RecruitClientContactService : IRecruitClientContactService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<RecruitClientContact> _recruitClientContactRepo;

        public RecruitClientContactService(ApplicationDBContext Context, ISqlRepository<RecruitClientContact> recruitClientDocumentRepo)
        {

            _Context = Context;
            _recruitClientContactRepo = recruitClientDocumentRepo;
        }
        public RecruitClientContact GetRecruitClientContactId(int RecruitClientContactId)
        {
            try
            {
                return _Context.RecruitClientContacts.Where(x => x.RecruitClientContactId == RecruitClientContactId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;

            }
        }

        public List<RecruitClientContact> GetRecruitClientContactList()
        {

            try
            {
                return _Context.RecruitClientContacts
                    .Include(x => x.RecruitClient)
                    .Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public MessageEnum RecruitClientContactCreate(RecruitClientContactDTO recruitClientContactDTO)
        {
            var objCheck = _Context.RecruitClientContacts.SingleOrDefault(x => x.RecruitClientContactId == recruitClientContactDTO.RecruitClientContactId && x.Deleted == false);
            try
            {
                if (objCheck == null)
                {
                    RecruitClientContact recruitClientContact = new RecruitClientContact();

                    recruitClientContact.RecruitClientId = recruitClientContactDTO.RecruitClientId;
                    recruitClientContact.ContactName = recruitClientContactDTO.ContactName;
                    recruitClientContact.ContactEmail = recruitClientContactDTO.ContactEmail;
                    recruitClientContact.ContactPhone = recruitClientContactDTO.ContactPhone;
                    recruitClientContact.DepartmentName = recruitClientContactDTO.DepartmentName;
                    recruitClientContact.JobTitle = recruitClientContactDTO.JobTitle;
                    recruitClientContact.CreatedBy = recruitClientContactDTO.CreatedBy;
                    var obj = _recruitClientContactRepo.Insert(recruitClientContact);
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

        public MessageEnum RecruitClientContactDelete(int RecruitClientContactId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.RecruitClientContacts.Where(x => x.RecruitClientContactId == RecruitClientContactId).FirstOrDefault();
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

        public MessageEnum RecruitClientContactUpdate(RecruitClientContactDTO recruitClientContactDTO)
        {
            try
            {
                var RecruitClientContact = _Context.RecruitClientContacts.Where(x => x.RecruitClientContactId != recruitClientContactDTO.RecruitClientContactId && x.Deleted == false).FirstOrDefault();
                if (RecruitClientContact == null)
                {
                    var a = _Context.RecruitClientContacts.Where(x => x.RecruitClientContactId == recruitClientContactDTO.RecruitClientContactId).FirstOrDefault();
                    if (a != null)
                    {

                        a.RecruitClientId = recruitClientContactDTO.RecruitClientId;
                        a.ContactName = recruitClientContactDTO.ContactName;
                        a.ContactEmail = recruitClientContactDTO.ContactEmail;
                        a.ContactPhone = recruitClientContactDTO.ContactPhone;
                        a.DepartmentName = recruitClientContactDTO.DepartmentName;
                        a.JobTitle = recruitClientContactDTO.JobTitle;

                        a.UpdatedBy = recruitClientContactDTO.CreatedBy;
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
