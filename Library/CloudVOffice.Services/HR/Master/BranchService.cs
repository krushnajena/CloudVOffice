using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;

namespace CloudVOffice.Services.HR.Master
{
    public class BranchService : IBranchService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<Branch> _branchRepo;
        public BranchService(ApplicationDBContext Context, ISqlRepository<Branch> branchRepo)
        {

            _Context = Context;
            _branchRepo = branchRepo;
        }
        public MessageEnum BranchCreate(BranchDTO branchDTO)
        {
            try
            {
                var branch = _Context.Branches.Where(x => x.BranchName == branchDTO.BranchName && x.Deleted == false).FirstOrDefault();
                if (branch == null)
                {
                    _branchRepo.Insert(new Branch()
                    {
                        BranchName = branchDTO.BranchName,
                        CreatedBy = branchDTO.CreatedBy,
                        CreatedDate = DateTime.Now,
                        Deleted = false
                    });
                    return MessageEnum.Success;
                }
                else
                    return MessageEnum.Duplicate;
            }
            catch
            {
                throw;
            }


        }

        public MessageEnum BranchDelete(Int64 branchId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.Branches.Where(x => x.BranchId == branchId).FirstOrDefault();
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

        public MessageEnum BranchUpdate(BranchDTO branchDTO)
        {
            try
            {
                var branch = _Context.Branches.Where(x => x.BranchId != branchDTO.BranchId && x.BranchName == branchDTO.BranchName && x.Deleted == false).FirstOrDefault();
                if (branch == null)
                {
                    var a = _Context.Branches.Where(x => x.BranchId == branchDTO.BranchId).FirstOrDefault();
                    if (a != null)
                    {
                        a.BranchName = branchDTO.BranchName;
                        a.UpdatedBy = branchDTO.CreatedBy;
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

        public Branch GetBranchByBranchId(Int64 branchId)
        {
            try
            {
                return _Context.Branches.Where(x => x.BranchId == branchId && x.Deleted == false).SingleOrDefault();

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
                return _Context.Branches.Where(x => x.BranchName == branchName && x.Deleted == false).SingleOrDefault();

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
                return _Context.Branches.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }
    }
}
