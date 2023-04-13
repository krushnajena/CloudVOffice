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
    public interface IBranchService
    {
        public MennsageEnum BranchCreate(BranchDTO branchDTO);
        public List<Branch> GetBranches();
        public Branch GetBranchByBranchId(Int64 branchId);
        public Branch GetBranchByBranchName(string branchName);
        public MennsageEnum BranchUpdate(BranchDTO branchDTO);
        public MennsageEnum BranchDelete(Int64 branchId, Int64 DeletedBy);
    }
}
