using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.HR.Master
{
    public interface IDesignationService
    {
        public MennsageEnum CreateDesignation(DesignationDTO designationDTO);
        public List<Designation> GetDesignationList();
        public Designation GetDesignationById(int designationId);
        public MennsageEnum DesignationUpdate(DesignationDTO designationDTO);
        public MennsageEnum DesignationDelete(int designationId, int DeletedBy);
    }
}
