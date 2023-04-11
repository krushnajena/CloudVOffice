using Azure.Security.KeyVault.Keys;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.CodeAnalysis.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.HR.Master
{
    public class BranchService : IBranchService
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly ISqlRepository<Branch> _branchRepo;
        public BranchService(ApplicationDBContext dbContext, ISqlRepository<Branch> branchRepo) {

            _dbContext = dbContext;
            _branchRepo = branchRepo;
        }
        public string BranchCreate(BranchDTO branchDTO)
        {
            try
            {
                var brach = _dbContext.Branches.Where(x => x.BranchName == branchDTO.BranchName && x.Deleted == false).FirstOrDefault();
                if (brach == null)
                {
                    _branchRepo.Insert(new Branch()
                    {
                        BranchName = branchDTO.BranchName,
                        CreatedBy = branchDTO.CreatedBy,
                        CreatedDate = DateTime.Now,
                        Deleted = false
                    });
                    return "Success";
                }
                else
                    return "duplicate";
            }
            catch
            {
                throw;
            }
          

        }

        public string BranchDelete(int branchId, int DeletedBy)
        {
            try
            {
                var a = _dbContext.Branches.Where(x => x.BranchId == branchId).FirstOrDefault();
                if (a != null)
                {
                    a.Deleted = true;
                    a.UpdatedBy = DeletedBy;
                    a.UpdatedDate = DateTime.Now;
                    _dbContext.SaveChanges();
                    return "deleted";
                }
                else
                    return "invalid";
            }
            catch
            {
                throw;
            }
            
        }

        public string BranchUpdate(BranchDTO branchDTO)
        {
            try
            {
                var branch = _dbContext.Branches.Where(x => x.BranchId != branchDTO.BranchId && x.BranchName == branchDTO.BranchName && x.Deleted==false).FirstOrDefault();
                if(branch == null)
                {
                    var a = _dbContext.Branches.Where(x => x.BranchId == branchDTO.BranchId).FirstOrDefault();
                    if (a != null)
                    {
                        a.BranchName = branchDTO.BranchName;
                        a.UpdatedBy = branchDTO.CreatedBy;
                        a.UpdatedDate = DateTime.Now;
                        _dbContext.SaveChanges();
                        return "updated";
                    }
                    else
                        return "invalid";
                }
                else
                {
                    return "duplicate";
                }
                
            }
            catch
            {
                throw;
            }
        }

        public Branch GetBranchByBranchId(int branchId)
        {
            try
            {
                return _dbContext.Branches.Where(x => x.BranchId == branchId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
          
        }

        public Branch GetBranchByBranchName(string branchName)
        {
            try
            {
                return _dbContext.Branches.Where(x => x.BranchName == branchName && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<Branch> GetBranches()
        {
            try
            {
                return _dbContext.Branches.Where(x =>  x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }
    }
}
