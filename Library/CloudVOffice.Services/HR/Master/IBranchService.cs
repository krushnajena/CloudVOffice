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
        public string BranchCreate(BranchDTO branchDTO);
        public List<Branch> GetBranches();
        public Branch GetBranchByBranchId(int branchId);
        public Branch GetBranchByBranchName(string branchName);
        public string BranchUpdate(BranchDTO branchDTO);
        public string BranchDelete(int branchId, int DeletedBy);
    }
}
