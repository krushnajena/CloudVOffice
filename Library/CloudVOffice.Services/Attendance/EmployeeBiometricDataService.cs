using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
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
	public class EmployeeBiometricDataService : IEmployeeBiometricDataService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<EmployeeBiometricData> _employeeBiometricDataRepo;
		public EmployeeBiometricDataService(ApplicationDBContext Context, ISqlRepository<EmployeeBiometricData> employeeBiometricDataRepo)
		{

			_Context = Context;
			_employeeBiometricDataRepo = employeeBiometricDataRepo;
		}
		public MessageEnum CreateEmployeeBiometricData(EmployeeBiometricDataDTO employeeBiometricDataDTO)
		{

			try
			{
				var EmployeeBiometricData = _Context.EmployeeBiometricDatas.Where(x => x.EmployeeId == employeeBiometricDataDTO.EmployeeId && x.Deleted == false).FirstOrDefault();
				if (EmployeeBiometricData == null)
				{
					_employeeBiometricDataRepo.Insert(new EmployeeBiometricData()
					{
						EmployeeId = employeeBiometricDataDTO.EmployeeId,
						ISOImage1 = employeeBiometricDataDTO.ISOImage1,
						ISOTemplate1 = employeeBiometricDataDTO.ISOTemplate1,
						AnsiTemplate1 = employeeBiometricDataDTO.AnsiTemplate1,
						RawData1 = employeeBiometricDataDTO.RawData1,
						WSQImage1 = employeeBiometricDataDTO.WSQImage1,
						ISOImage2 = employeeBiometricDataDTO.ISOImage2,
						ISOTemplate2 = employeeBiometricDataDTO.ISOTemplate2,
						AnsiTemplate2 = employeeBiometricDataDTO.AnsiTemplate2,
						RawData2 = employeeBiometricDataDTO.RawData2,
						WSQImage2 = employeeBiometricDataDTO.WSQImage2,
						ISOImage3 = employeeBiometricDataDTO.ISOImage3,
						ISOTemplate3 = employeeBiometricDataDTO.ISOTemplate3,
						AnsiTemplate3 = employeeBiometricDataDTO.AnsiTemplate3,
						RawData3 = employeeBiometricDataDTO.RawData3,
						WSQImage3 = employeeBiometricDataDTO.WSQImage3,
						CreatedBy = employeeBiometricDataDTO.CreatedBy,
						CreatedDate = DateTime.Now,
						Deleted = false
					});
					return MessageEnum.Success;
				}
				else
					return MessageEnum.Duplicate;
			}
			catch
			{
				throw;
			}
		}

		public MessageEnum EmployeeBiometricDataDelete(int employeeBiometricDataId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.EmployeeBiometricDatas.Where(x => x.EmployeeId == employeeBiometricDataId).FirstOrDefault();
				if (a != null)
				{
					a.Deleted = true;
					a.UpdatedBy = DeletedBy;
					a.UpdatedDate = DateTime.Now;
					_Context.SaveChanges();
					return MessageEnum.Deleted;
				}
				else
					return MessageEnum.Invalid;
			}
			catch
			{
				throw;
			}

			
		}

		public MessageEnum EmployeeBiometricDataUpdate(EmployeeBiometricDataDTO employeeBiometricDataDTO)
		{
			try
			{
				var EmployeeBiometricData = _Context.EmployeeBiometricDatas.Where(x => x.EmployeeBiometricDataId != employeeBiometricDataDTO.EmployeeBiometricDataId && x.EmployeeId == employeeBiometricDataDTO.EmployeeId && x.Deleted == false).FirstOrDefault();
				if (EmployeeBiometricData == null)
				{
					var a = _Context.EmployeeBiometricDatas.Where(x => x.EmployeeBiometricDataId == employeeBiometricDataDTO.EmployeeBiometricDataId).FirstOrDefault();
					if (a != null)
					{
						a.EmployeeId = employeeBiometricDataDTO.EmployeeId;
						a.ISOImage1 = employeeBiometricDataDTO.ISOImage1;
						a.ISOTemplate1 = employeeBiometricDataDTO.ISOTemplate1;
						a.AnsiTemplate1 = employeeBiometricDataDTO.AnsiTemplate1;
						a.RawData1 = employeeBiometricDataDTO.RawData1;
						a.WSQImage1 = employeeBiometricDataDTO.WSQImage1;
						a.ISOImage2 = employeeBiometricDataDTO.ISOImage2;
						a.ISOTemplate2 = employeeBiometricDataDTO.ISOTemplate2;
						a.AnsiTemplate2 = employeeBiometricDataDTO.AnsiTemplate2;
						a.RawData2 = employeeBiometricDataDTO.RawData2;
						a.WSQImage2 = employeeBiometricDataDTO.WSQImage2;
						a.ISOImage3 = employeeBiometricDataDTO.ISOImage2;
						a.ISOTemplate3 = employeeBiometricDataDTO.ISOTemplate2;
						a.AnsiTemplate3 = employeeBiometricDataDTO.AnsiTemplate2;
						a.RawData3 = employeeBiometricDataDTO.RawData2;
						a.WSQImage3 = employeeBiometricDataDTO.WSQImage2;
						a.UpdatedBy = employeeBiometricDataDTO.CreatedBy;
						a.UpdatedDate = DateTime.Now;
						_Context.SaveChanges();
						return MessageEnum.Updated;
					}
					else
						return MessageEnum.Invalid;
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

		public EmployeeBiometricData GetEmployeeBiometricDataById(int employeeBiometricDataId)
		{
			try
			{
				return _Context.EmployeeBiometricDatas.Where(x => x.EmployeeBiometricDataId == employeeBiometricDataId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public List<EmployeeBiometricData> GetEmployeeBiometricDataList()
		{
			try
			{
				return _Context.EmployeeBiometricDatas.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}
}	}
