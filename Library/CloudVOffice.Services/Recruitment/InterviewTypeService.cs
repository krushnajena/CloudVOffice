using CloudVOffice.Core.Domain.Common;

using CloudVOffice.Core.Domain.Recruitment;

using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;


namespace CloudVOffice.Services.Recruitment
{
    public class InterviewTypeService : IInterviewTypeService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<InterviewType> _interviewTypeRepo;
        public InterviewTypeService(ApplicationDBContext Context, ISqlRepository<InterviewType> interviewTypeRepo)
        {

            _Context = Context;
            _interviewTypeRepo = interviewTypeRepo;
        }
        public MessageEnum CreateInterviewType(InterviewTypeDTO interviewTypeDTO)
        {
            var objCheck = _Context.InterviewTypes.SingleOrDefault(opt => opt.InterviewTypeId == interviewTypeDTO.InterviewTypeId && opt.Deleted == false);
            try
            {
                if (objCheck == null)
                {

                    InterviewType interviewType = new InterviewType();
                    interviewType.InterviewTypeName = interviewTypeDTO.InterviewTypeName;
                    interviewType.CreatedBy = interviewTypeDTO.CreatedBy;
                    var obj = _interviewTypeRepo.Insert(interviewType);

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

        public InterviewType GetInterviewTypeById(Int64 InterviewTypeId)
        {
            try
            {
                return _Context.InterviewTypes.Where(x => x.InterviewTypeId == InterviewTypeId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<InterviewType> GetInterviewTypeList()
        {
            try
            {
                return _Context.InterviewTypes.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public MessageEnum InterviewTypeDelete(Int64 InterviewTypeId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.InterviewTypes.Where(x => x.InterviewTypeId == InterviewTypeId).FirstOrDefault();
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

        public MessageEnum InterviewTypeUpdate(InterviewTypeDTO interviewTypeDTO)
        {
			try
			{
				var interviewType = _Context.InterviewTypes.Where(x => x.InterviewTypeId != interviewTypeDTO.InterviewTypeId && x.InterviewTypeName == interviewTypeDTO.InterviewTypeName && x.Deleted == false).FirstOrDefault();
				if (interviewType == null)
				{
					var a = _Context.InterviewTypes.Where(x => x.InterviewTypeId == interviewTypeDTO.InterviewTypeId).FirstOrDefault();
					if (a != null)
					{
						a.InterviewTypeName = interviewTypeDTO.InterviewTypeName;
						a.UpdatedBy = interviewTypeDTO.CreatedBy;
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
