using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;

namespace CloudVOffice.Services.HR.Master
{
    public interface IBranchService
    {
        public MessageEnum BranchCreate(BranchDTO branchDTO);
        public List<Branch> GetBranches();
        public Branch GetBranchByBranchId(Int64 branchId);
        public Branch GetBranchByBranchName(string branchName);
        public MessageEnum BranchUpdate(BranchDTO branchDTO);
        public MessageEnum BranchDelete(Int64 branchId, Int64 DeletedBy);
    }
}
