using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.HR.Master
{
    public class DesignationSevice: IDesignationService
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly ISqlRepository<Designation> _designationRepo;
        public DesignationSevice(ApplicationDBContext dbContext, ISqlRepository<Designation> designationRepo) 
        {
            _dbContext = dbContext;
            _designationRepo = designationRepo;
        }

        public string DesignationCreate(DesignationDTO designationDTO)
        {
            throw new NotImplementedException();
        }

        public string DesignationDelete(int designationId, int DeletedBy)
        {
            throw new NotImplementedException();
        }

        public string DesignationUpdate(DesignationDTO designationDTO)
        {
            throw new NotImplementedException();
        }

        public Designation GetDesignationByDesignationId(int designationId)
        {
            throw new NotImplementedException();
        }

        public Designation GetDesignationByDesignationName(string designationName)
        {
            throw new NotImplementedException();
        }

        public List<Designation> GetDesignations()
        {
            throw new NotImplementedException();
        }
    }
}
