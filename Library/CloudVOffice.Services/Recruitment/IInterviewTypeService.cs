using CloudVOffice.Core.Domain.Common;

using CloudVOffice.Core.Domain.Recruitment;

using CloudVOffice.Data.DTO.Recruitment;


namespace CloudVOffice.Services.Recruitment
{
    public interface IInterviewTypeService
    {
        public MessageEnum CreateInterviewType(InterviewTypeDTO interviewTypeDTO);
        public List<InterviewType> GetInterviewTypeList();
        public InterviewType GetInterviewTypeById(Int64 InterviewTypeId);
        public MessageEnum InterviewTypeUpdate(InterviewTypeDTO interviewTypeDTO);
        public MessageEnum InterviewTypeDelete(Int64 InterviewTypeId, Int64 DeletedBy);
    }
}
