using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Data.ViewModel.Attendance;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Attendance
{
	public class LeavePolicyDetailsService : ILeavePolicyDetailsService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<LeavePolicyDetails> _leavePolicyDetailsRepo;
	   
		public LeavePolicyDetailsService(ApplicationDBContext Context, ISqlRepository<LeavePolicyDetails> leavePolicyDetailsRepo)
			
		{

			_Context = Context;
			_leavePolicyDetailsRepo = leavePolicyDetailsRepo;
           

        }
		public MessageEnum LeavePolicyDetailsCreate(LeavePolicyDetailsDTO leavePolicyDetailsDTO)
		{
			var objCheck = _Context.LeavePolicyDetails.SingleOrDefault(x => x.LeavePolicyId == leavePolicyDetailsDTO.LeavePolicyId && x.LeaveTypeId == leavePolicyDetailsDTO.LeaveTypeId && x.Deleted == false);
			try
			{
				if (objCheck == null)
				{
					LeavePolicyDetails leavePolicyDetails = new LeavePolicyDetails();
					leavePolicyDetails.LeavePolicyId = (int)leavePolicyDetailsDTO.LeavePolicyId;
					leavePolicyDetails.LeaveTypeId = leavePolicyDetailsDTO.LeaveTypeId;
					leavePolicyDetails.NoOfLeaves = leavePolicyDetailsDTO.NoOfLeaves;
					leavePolicyDetails.AllocationMode = leavePolicyDetailsDTO.AllocationMode;
					leavePolicyDetails.CreatedBy = (long)leavePolicyDetailsDTO.CreatedBy;
					var obj = _leavePolicyDetailsRepo.Insert(leavePolicyDetails);

					return MessageEnum.Success;

				}
				else if (objCheck != null)
				{
					return MessageEnum.Duplicate;
				}
				return MessageEnum.UnExpectedError;
			}
			catch
			{
				throw;
			}
		}
		public LeavePolicyDetails GetLeavePolicyDetailsById(int leavePolicyDetailsId)
		{
			try
			{
				return _Context.LeavePolicyDetails.Where(x => x.LeavePolicyDetailsId == leavePolicyDetailsId && x.Deleted == false).SingleOrDefault();
			}
			catch
			{
				throw;
			}
		}

		public List<LeavePolicyDetails> GetLeavePolicyDetailsList()
		{
			try
			{
				return _Context.LeavePolicyDetails.Where(x => x.Deleted == false).ToList();



            }
			catch
			{
				throw;
			}

		}



		public MessageEnum LeavePolicyDetailsDelete(int leavePolicyDetailsId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.LeavePolicyDetails.Where(x => x.LeavePolicyDetailsId == leavePolicyDetailsId).FirstOrDefault();
				if (a != null)
				{
					a.Deleted = true;
					a.UpdatedBy = DeletedBy;
					a.UpdatedDate = DateTime.Now;
					_Context.SaveChanges();
					return MessageEnum.Deleted;
				}
				else
				{
					return MessageEnum.Invalid;
				}
			}
			catch
			{
				throw;
			}
		}

		public MessageEnum LeavePolicyDetailsUpdate(LeavePolicyDetailsDTO leavePolicyDetailsDTO)
		{
			try
			{
				var leavePolicyDetails = _Context.LeavePolicyDetails.Where(x => x.LeavePolicyDetailsId != leavePolicyDetailsDTO.LeavePolicyDetailsId && x.Deleted == false).FirstOrDefault();
				if (leavePolicyDetails == null)
				{
					var a = _Context.LeavePolicyDetails.Where(x => x.LeavePolicyDetailsId == leavePolicyDetailsDTO.LeavePolicyDetailsId).FirstOrDefault();
					if (a != null)
					{
						a.LeavePolicyId = (int)leavePolicyDetailsDTO.LeavePolicyId;
						a.LeaveTypeId = leavePolicyDetailsDTO.LeaveTypeId;
						a.NoOfLeaves = leavePolicyDetailsDTO.NoOfLeaves;
						a.AllocationMode = leavePolicyDetailsDTO.AllocationMode;
						a.UpdatedBy = leavePolicyDetailsDTO.CreatedBy;
						a.UpdatedDate = DateTime.Now;
						_Context.SaveChanges();
						return MessageEnum.Updated;
					}
					else
					{
						return MessageEnum.Invalid;
					}
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

		public List<LeavePolicy> GetLeavePolicyByLeavePolicyId(int leavePolicyId)
		{
			try
			{
				return _Context.LeavePolicies.Where(x => x.LeavePolicyId == leavePolicyId && x.Deleted == false).ToList();





            }
			catch
			{
				throw;
			}
		}

		public List<LeavePolicyDetails> GetLeavePolicyDetailsByLeavePolicyId(int leavePolicyId)
		{
			try
			{
				return _Context.LeavePolicyDetails
					.Include(x => x.LeaveType)
					.Where(x => x.LeavePolicyId == leavePolicyId && x.Deleted == false).ToList();
			}
			catch
			{
				throw;
			}
		}


	}
}
