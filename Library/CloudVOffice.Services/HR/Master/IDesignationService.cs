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
        public MessageEnum CreateDesignation(DesignationDTO designationDTO);
        public List<Designation> GetDesignationList();
        public Designation GetDesignationById(Int64 designationId);
        public MessageEnum DesignationUpdate(DesignationDTO designationDTO);
        public MessageEnum DesignationDelete(Int64 designationId, Int64 DeletedBy);
       
    }
}
