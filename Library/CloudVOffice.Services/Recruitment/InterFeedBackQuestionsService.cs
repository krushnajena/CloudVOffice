using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment
{
    public class InterFeedBackQuestionsService : IInterFeedBackQuestionsService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<InterFeedBackQuestions> _interFeedBackQuestionsRepo;

        public InterFeedBackQuestionsService(ApplicationDBContext Context, ISqlRepository<InterFeedBackQuestions> interFeedBackQuestionsRepo)
        {
            _Context = Context;
            _interFeedBackQuestionsRepo = interFeedBackQuestionsRepo;
        }

        public MessageEnum InterFeedBackQuestionsCreate(InterFeedBackQuestionsDTO interFeedBackQuestionsDTO)
        {
            var objCheck = _Context.InterFeedBackQuestions.SingleOrDefault(x => x.InterFeedBackQuestionsId == interFeedBackQuestionsDTO.InterFeedBackQuestionsId && x.Deleted == false);
            try
            {
                if (objCheck == null)
                {
                    InterFeedBackQuestions interFeedBackQuestions = new InterFeedBackQuestions();
                    interFeedBackQuestions.DesignationId = interFeedBackQuestionsDTO.DesignationId;
                    interFeedBackQuestions.InterviewRoundId = interFeedBackQuestionsDTO.InterviewRoundId;
                    interFeedBackQuestions.Question = interFeedBackQuestionsDTO.Question;
                    interFeedBackQuestions.Mark = interFeedBackQuestionsDTO.Mark;
                    interFeedBackQuestions.CreatedBy = interFeedBackQuestionsDTO.CreatedBy;
                    var obj = _interFeedBackQuestionsRepo.Insert(interFeedBackQuestions);
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
        public InterFeedBackQuestions GetInterFeedBackQuestionsById(int interFeedBackQuestionsId)
        {
            try
            {
                return _Context.InterFeedBackQuestions.Where(x => x.InterFeedBackQuestionsId == interFeedBackQuestionsId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;

            }
        }

        public List<InterFeedBackQuestions> GetInterFeedBackQuestionsList()
        {
            try
            {
                return _Context.InterFeedBackQuestions.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public MessageEnum InterFeedBackQuestionsDelete(int interFeedBackQuestionsId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.InterFeedBackQuestions.Where(x => x.InterFeedBackQuestionsId == interFeedBackQuestionsId).FirstOrDefault();
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

        public MessageEnum InterFeedBackQuestionsUpdate(InterFeedBackQuestionsDTO interFeedBackQuestionsDTO)
        {
            try
            {
                var interFeedBackQuestions = _Context.InterFeedBackQuestions.Where(x => x.InterFeedBackQuestionsId != interFeedBackQuestionsDTO.InterFeedBackQuestionsId && x.Deleted == false).FirstOrDefault();
                if (interFeedBackQuestions == null)
                {
                    var a = _Context.InterFeedBackQuestions.Where(x => x.InterFeedBackQuestionsId == interFeedBackQuestionsDTO.InterFeedBackQuestionsId).FirstOrDefault();
                    if (a != null)
                    {
                        a.DesignationId = interFeedBackQuestionsDTO.DesignationId;
                        a.InterviewRoundId = interFeedBackQuestionsDTO.InterviewRoundId;
                        a.DesignationId = interFeedBackQuestionsDTO.DesignationId;
                        a.Question = interFeedBackQuestionsDTO.Question;
                        a.Mark = interFeedBackQuestionsDTO.Mark;
                        a.UpdatedBy = interFeedBackQuestionsDTO.CreatedBy;
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
