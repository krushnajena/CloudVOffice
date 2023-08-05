using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;

namespace CloudVOffice.Services.Attendance
{


	public class AttendanceDeviceService : IAttendanceDeviceService

		{
			private readonly ApplicationDBContext _Context;
			private readonly ISqlRepository<AttendanceDevice> _attendanceDeviceRepo;
			public AttendanceDeviceService(ApplicationDBContext Context, ISqlRepository<AttendanceDevice> attendanceDeviceRepo)
			{

				_Context = Context;
				_attendanceDeviceRepo = attendanceDeviceRepo;
			}
			public MessageEnum AttendanceDeviceDelete(int attendanceDeviceId, Int64 DeletedBy)
			{
				try
				{
					var a = _Context.AttendanceDevices.Where(x => x.AttendanceDeviceId == attendanceDeviceId).FirstOrDefault();
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

			public MessageEnum AttendanceDeviceUpdate(AttendanceDeviceDTO attendanceDeviceDTO)
			{
				try
				{
					var branch = _Context.AttendanceDevices.Where(x => x.AttendanceDeviceId != attendanceDeviceDTO.AttendanceDeviceId && x.DeviceSlNo == attendanceDeviceDTO.DeviceSlNo && x.Deleted == false).FirstOrDefault();
					if (branch == null)
					{
						var a = _Context.AttendanceDevices.Where(x => x.AttendanceDeviceId == attendanceDeviceDTO.AttendanceDeviceId).FirstOrDefault();
						if (a != null)
						{
							a.DeviceName = attendanceDeviceDTO.DeviceName;
							a.DeviceSlNo = attendanceDeviceDTO.DeviceSlNo;
							a.UpdatedBy = attendanceDeviceDTO.CreatedBy;
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

			public MessageEnum CreateAttendanceDevice(AttendanceDeviceDTO attendanceDeviceDTO)
			{
				try
				{
					var AttendanceDevice = _Context.AttendanceDevices.Where(x => x.DeviceSlNo == attendanceDeviceDTO.DeviceSlNo && x.Deleted == false).FirstOrDefault();
					if (AttendanceDevice == null)
					{
						_attendanceDeviceRepo.Insert(new AttendanceDevice()
						{
							DeviceName = attendanceDeviceDTO.DeviceName,
							DeviceSlNo = attendanceDeviceDTO.DeviceSlNo,
							CreatedBy = attendanceDeviceDTO.CreatedBy,
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



			AttendanceDevice IAttendanceDeviceService.GetAttendanceDeviceById(int attendanceDeviceId)
			{
				try
				{
					return _Context.AttendanceDevices.Where(x => x.AttendanceDeviceId == attendanceDeviceId && x.Deleted == false).SingleOrDefault();

				}
				catch
				{
					throw;
				}
			}

			List<AttendanceDevice> IAttendanceDeviceService.GetAttendanceDeviceList()
			{

				try
				{
					return _Context.AttendanceDevices.Where(x => x.Deleted == false).ToList();

				}
				catch
				{
					throw;
				}
			}
		}
	
}
