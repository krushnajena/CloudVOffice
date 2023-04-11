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
        public string CreateDesignation(DesignationDTO designationDTO);
        public List<Designation> GetDesignationList();
        public Designation GetDesignationById(int designationId);
        public string DesignationUpdate(DesignationDTO designationDTO);
        public string DesignationDelete(int designationId, int DeletedBy);
    }
}
