using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment.JO
{
    public interface IJobOpeningService
    {
        public MessageEnum JobOpeningCreate(JobOpeningDTO jobOpeningDTO);
        public List<JobOpening> GetJobOpeningsList();
        public JobOpening GetJobOpeningByJobOpeningId(int jobOpeningId);
        public MessageEnum JobOpeningUpdate(JobOpeningDTO jobOpeningDTO);
        public MessageEnum JobOpeningDelete(int jobOpeningId, long DeletedBy);
    }
}
