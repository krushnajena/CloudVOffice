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
        public string DesignationCreate(DesignationDTO designationDTO);
        public List<Designation> GetDesignations();
        public Designation GetDesignationByDesignationId(int designationId);
        public Designation GetDesignationByDesignationName(string designationName);
        public string DesignationUpdate(DesignationDTO designationDTO);
        public string DesignationDelete(int designationId, int DeletedBy);
    }
}
