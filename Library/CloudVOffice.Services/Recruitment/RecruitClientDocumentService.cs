using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
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
    public class RecruitClientDocumentService : IRecruitClientDocumentService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<RecruitClientDocument> _recruitClientDocumentRepo;

        public RecruitClientDocumentService (ApplicationDBContext Context, ISqlRepository<RecruitClientDocument> recruitClientDocumentRepo)
        {
            _Context = Context;
            _recruitClientDocumentRepo = recruitClientDocumentRepo;
        }

        public RecruitClientDocument GetRecruitClientDocumentById(long recruitClientDocumentId)
        {
            try
            {
                return _Context.RecruitClientDocuments.Where(x => x.RecruitClientDocumentId == recruitClientDocumentId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;

            }
        }

        public List<RecruitClientDocument> GetRecruitClientDocumentList()
        {
            try
            {
                return _Context.RecruitClientDocuments.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public MessageEnum RecruitClientDocumentCreate(RecruitClientDocumentDTO recruitClientDocumentDTO)
        {
            var objCheck = _Context.RecruitClientDocuments.SingleOrDefault(x => x.RecruitClientDocumentId == recruitClientDocumentDTO.RecruitClientDocumentId && x.Deleted == false);
            try
            {
                if (objCheck == null)
                {
                    RecruitClientDocument recruitClientDocument = new RecruitClientDocument();
                    recruitClientDocument.RecruitClientId = recruitClientDocumentDTO.RecruitClientId;
                    recruitClientDocument.DocumentType = recruitClientDocumentDTO.DocumentType;
                    recruitClientDocument.Document = recruitClientDocumentDTO.Document;
                    recruitClientDocument.CreatedBy = recruitClientDocumentDTO.CreatedBy;
                    var obj = _recruitClientDocumentRepo.Insert(recruitClientDocument);
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

        public MessageEnum RecruitClientDocumentDelete(long recruitClientDocumentId, long DeletedBy)
        {
            try
            {
                var a = _Context.RecruitClientDocuments.Where(x => x.RecruitClientDocumentId == recruitClientDocumentId).FirstOrDefault();
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

        public MessageEnum RecruitClientDocumentUpdate(RecruitClientDocumentDTO recruitClientDocumentDTO)
        {
            try
            {
                var recruitClientDocuments = _Context.RecruitClientDocuments.Where(x => x.RecruitClientDocumentId != recruitClientDocumentDTO.RecruitClientDocumentId && x.Document == recruitClientDocumentDTO.Document && x.Deleted == false).FirstOrDefault();
                if (recruitClientDocuments == null)
                {
                    var a = _Context.RecruitClientDocuments.Where(x => x.RecruitClientDocumentId == recruitClientDocumentDTO.RecruitClientDocumentId ).FirstOrDefault();
                    if (a != null)
                    {
                        a.RecruitClientId = recruitClientDocumentDTO.RecruitClientId;
                        a.DocumentType = recruitClientDocumentDTO.DocumentType;
                        a.Document = recruitClientDocumentDTO.Document;
                        a.UpdatedBy = recruitClientDocumentDTO.CreatedBy;
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

        public List<RecruitClient> DeleteByClientId(int RecruitClientId)
        {
            try
            {
                return _Context.RecruitClients.Where(x => x.RecruitClientId == RecruitClientId && x.Deleted == false).ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
