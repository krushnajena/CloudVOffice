using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.DTO.HR.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Attendance
{
	public interface IShiftTypeService
	{
		public MessageEnum CreateShiftType(ShiftTypeDTO shiftTypeDTO);
		public List<ShiftType> GetShiftTypeList();
		public ShiftType GetShiftTypeById(Int64 shiftTypeId);
		public MessageEnum ShiftTypeUpdate(ShiftTypeDTO shiftTypeDTO);
		public MessageEnum ShiftTypeDelete(Int64 shiftTypeId, Int64 DeletedBy);
	}
}
