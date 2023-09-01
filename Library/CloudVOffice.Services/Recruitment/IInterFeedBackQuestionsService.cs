using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment
{
    public interface IInterFeedBackQuestionsService
    {
        public MessageEnum InterFeedBackQuestionsCreate(InterFeedBackQuestionsDTO interFeedBackQuestionsDTO);
        public List<InterFeedBackQuestions> GetInterFeedBackQuestionsList();
        public InterFeedBackQuestions GetInterFeedBackQuestionsById(int interFeedBackQuestionsId);
        public MessageEnum InterFeedBackQuestionsUpdate(InterFeedBackQuestionsDTO interFeedBackQuestionsDTO);
        public MessageEnum InterFeedBackQuestionsDelete(int interFeedBackQuestionsId, Int64 DeletedBy);
    }
}
