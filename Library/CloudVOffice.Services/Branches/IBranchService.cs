using CloudVOffice.Core.Domain.HR.Master;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Branches
{
    public interface IBranchService
    {
        public string InsertBranch(string branchName);
        public List<Branch> GetAllBranch();
        public Branch GetBranchsingleid();
        public Branch UpdateBranch(int branchid, string branchname, int CreatedBy);
        public Branch DeleteBranch(int branchid);
    }
}
