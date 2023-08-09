using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Attendance
{
	public interface IEmployeeBiometricDataService
	{
		public MessageEnum CreateEmployeeBiometricData(EmployeeBiometricDataDTO employeeBiometricDataDTO);
		public List<EmployeeBiometricData> GetEmployeeBiometricDataList();
		public EmployeeBiometricData GetEmployeeBiometricDataById(int employeeBiometricDataId);
		public MessageEnum EmployeeBiometricDataUpdate(EmployeeBiometricDataDTO employeeBiometricDataDTO);
		public MessageEnum EmployeeBiometricDataDelete(int employeeBiometricDataId, Int64 DeletedBy);
	}
}
