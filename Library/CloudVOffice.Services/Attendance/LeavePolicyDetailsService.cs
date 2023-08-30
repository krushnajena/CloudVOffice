using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
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
			var objCheck = _Context.Lea
		}
		public LeavePolicyDetails GetLeavePolicyDetailsById(int leavePolicyDetailsId)
		{
			throw new NotImplementedException();
		}

		public List<LeavePolicyDetails> GetLeavePolicyDetailsList()
		{
			throw new NotImplementedException();
		}

		

		public MessageEnum LeavePolicyDetailsDelete(int leavePolicyDetailsId)
		{
			throw new NotImplementedException();
		}

		public MessageEnum LeavePolicyDetailsUpdate(LeavePolicyDetailsDTO leavePolicyDetailsDTO)
		{
			throw new NotImplementedException();
		}
	}
}
