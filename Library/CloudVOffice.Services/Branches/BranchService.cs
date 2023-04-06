using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Branches
{
    public class BranchService : IBranchService
    {
        private readonly ApplicationDBContext _context;
        private readonly ISqlRepository<Branch> _branchRepo;

        public BranchService(ApplicationDBContext context, ISqlRepository<Branch> branchRepo)
        {
            _context = context;
            _branchRepo = branchRepo;
        }
        public Branch GetBranchsingleid()
        {
            throw new NotImplementedException();
        }

        public string InsertBranch(string branchName)
        {
            var objCheck = _context.Branches.SingleOrDefault(opt => opt.BranchName == branchName);
            try
            {
                if (objCheck == null)
                {
                    Branch branch = new Branch();
                    branch.BranchName = branchName;
                    var obj = _branchRepo.Insert(branch);
                    return "Branck Creat Sucessfully";
                }
                else if (objCheck == null)
                {
                    return "Duplicate";
                }
                return "Something Unexpected!";
            }
            catch (Exception ex)
            {
                return "Error!";
            }
        }
        public List<Branch> GetAllBranch()
        {
            return _context.Branches.Where(x => x.Deleted == false).ToList();
        }

        public Branch GetBranchsingleid(int BranchId)
        {
            try
            {
                var SingleBranch = _branchRepo.SelectById(BranchId);
                return SingleBranch;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public Branch UpdateBranch(int branchid, string branchname, int CreatedBy)
        {
            try
            {
                var objbranch = _context.Branches.SingleOrDefault(opt => opt.BranchId == branchid);
                objbranch.BranchName = branchname;
                objbranch.CreatedBy = CreatedBy;
                objbranch.CreatedDate = DateTime.Now;
                _context.SaveChanges();
                return objbranch;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public Branch DeleteBranch(int branchid)
        {
            try
            {
                var obj = _context.Branches.SingleOrDefault(opt => opt.BranchId == branchid);
                _context.SaveChanges();
                return obj;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
