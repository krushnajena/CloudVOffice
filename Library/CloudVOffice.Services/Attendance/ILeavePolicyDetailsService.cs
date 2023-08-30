using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Attendance
{
	public interface ILeavePolicyDetailsService
	{
		public MessageEnum LeavePolicyDetailsCreate(LeavePolicyDetailsDTO leavePolicyDetailsDTO);
		public List<LeavePolicyDetails> GetLeavePolicyDetailsList();
		public LeavePolicyDetails GetLeavePolicyDetailsById(int leavePolicyDetailsId);
		public MessageEnum LeavePolicyDetailsUpdate (LeavePolicyDetailsDTO leavePolicyDetailsDTO);
		public MessageEnum LeavePolicyDetailsDelete(int leavePolicyDetailsId);


	}
}
