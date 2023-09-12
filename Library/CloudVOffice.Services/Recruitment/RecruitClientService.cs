using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment
{
    public class RecruitClientService : IRecruitClientService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<RecruitClient> _recruitClientRepo;
        private readonly IRecruitClientDocumentService _recruitClientDocumentService;
        public RecruitClientService(ApplicationDBContext Context, ISqlRepository<RecruitClient> recruitClientRepo, IRecruitClientDocumentService recruitClientDocumentService)
        {

            _Context = Context;
            _recruitClientRepo = recruitClientRepo;
            _recruitClientDocumentService = recruitClientDocumentService;
        }
        public MessageEnum RecruitClientCreate(RecruitClientDTO recruitClientDTO)
        {
            var objCheck = _Context.RecruitClients.SingleOrDefault(x => x.RecruitClientId == recruitClientDTO.RecruitClientId && x.Deleted == false);
            try
            {
                if (objCheck == null)
                {
                    RecruitClient recruitClient = new RecruitClient();

                    recruitClient.ClientName = recruitClientDTO.ClientName;
                    recruitClient.ContactNo = recruitClientDTO.ContactNo;
                    recruitClient.AccountManagerId = recruitClientDTO.AccountManagerId;
                    recruitClient.Website = recruitClientDTO.Website;
                    recruitClient.Fax = recruitClientDTO.Fax;
                    recruitClient.About = recruitClientDTO.About;
                    recruitClient.BillingAddressLine1 = recruitClientDTO.BillingAddressLine1;
                    recruitClient.BillingAddressLine2 = recruitClientDTO.BillingAddressLine2;
                    recruitClient.BillingCity = recruitClientDTO.BillingCity;
                    recruitClient.BillingState = recruitClientDTO.BillingState;
                    recruitClient.BillingCountry = recruitClientDTO.BillingCountry;
                    recruitClient.BillingPostalCode = recruitClientDTO.BillingPostalCode;
                    recruitClient.CreatedBy = recruitClientDTO.CreatedBy;
                    var obj = _recruitClientRepo.Insert(recruitClient);
                   

                    for (int i = 0; i < recruitClientDTO.FileNames.Count; i++)
                    {
                        _recruitClientDocumentService.RecruitClientDocumentCreate(new RecruitClientDocumentDTO
                        {
                            RecruitClientId =obj.RecruitClientId,
                            DocumentType = "Contract Document",
                            Document = recruitClientDTO.FileNames[i],
                            CreatedBy = recruitClientDTO.CreatedBy
                            });
                    }


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
        public RecruitClient GetRecruitClientById(int recruitClientId)
        {
            try
            {
                return _Context.RecruitClients.Where(x => x.RecruitClientId == recruitClientId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;

            }
        }

        public List<RecruitClient> GetRecruitClientList()
        {
            try
            {
                return _Context.RecruitClients.Include(x => x.Employee) .Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public MessageEnum RecruitClientDelete(int recruitClientId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.RecruitClients.Where(x => x.RecruitClientId == recruitClientId).FirstOrDefault();
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

        public MessageEnum RecruitClientUpdate(RecruitClientDTO recruitClientDTO)
        {
            try
            {
                var recruitClient = _Context.RecruitClients.Where(x => x.RecruitClientId != recruitClientDTO.RecruitClientId && x.ClientName == recruitClientDTO.ClientName && x.Deleted == false).FirstOrDefault();
                if (recruitClient == null)
                {
                    var a = _Context.RecruitClients.Where(x => x.RecruitClientId == recruitClientDTO.RecruitClientId).FirstOrDefault();
                    if (a != null)
                    {

                        a.ClientName = recruitClientDTO.ClientName;
                        a.ContactNo = recruitClientDTO.ContactNo;
                        a.AccountManagerId = recruitClientDTO.AccountManagerId;
                        a.Website = recruitClientDTO.Website;
                        a.Fax = recruitClientDTO.Fax;
                        a.About = recruitClientDTO.About;
                        a.BillingAddressLine1 = recruitClientDTO.BillingAddressLine1;
                        a.BillingAddressLine2 = recruitClientDTO.BillingAddressLine2;
                        a.BillingCity = recruitClientDTO.BillingCity;
                        a.BillingState = recruitClientDTO.BillingState;
                        a.BillingCountry = recruitClientDTO.BillingCountry;
                        a.BillingPostalCode = recruitClientDTO.BillingPostalCode;
                        a.UpdatedBy = recruitClientDTO.CreatedBy;
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
