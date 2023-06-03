using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Migrations;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Projects
{
	public class TimesheetActivityCategoryService : ITimesheetActivityCategoryService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<TimesheetActivityCategory> _timesheetActivityCategoryRepo;
		public TimesheetActivityCategoryService(ApplicationDBContext Context, ISqlRepository<TimesheetActivityCategory> timesheetActivityCategoryRepo)
		{

			_Context = Context;
			_timesheetActivityCategoryRepo = timesheetActivityCategoryRepo;
		}
		public MessageEnum TimesheetActivityCategoryCreate(TimesheetActivityCategoryDTO timesheetActivityCategoryDTO)
		{
			try
			{
				var timesheetActivityCategory = _Context.TimesheetActivityCategories.Where(x => x.TimesheetActivityCategoryName == timesheetActivityCategoryDTO.TimesheetActivityCategoryName && x.Deleted == false).FirstOrDefault();
				if (timesheetActivityCategory == null)
				{
					_timesheetActivityCategoryRepo.Insert(new TimesheetActivityCategory()
					{
						TimesheetActivityCategoryName = timesheetActivityCategoryDTO.TimesheetActivityCategoryName,
						CreatedBy = timesheetActivityCategoryDTO.CreatedBy,
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
		public List<TimesheetActivityCategory> GetTimesheetActivityCategories()
		{
			try
			{
				return _Context.TimesheetActivityCategories.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

		public TimesheetActivityCategory GetTimesheetActivityCategoryByTimesheetActivityCategoryName(string timesheetActivityCategoryName)
		{
			try
			{
				return _Context.TimesheetActivityCategories.Where(x => x.TimesheetActivityCategoryName == timesheetActivityCategoryName && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		

		public MessageEnum TimesheetActivityCategoryDelete(int timesheetActivityCategoryId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.TimesheetActivityCategories.Where(x => x.TimesheetActivityCategoryId == timesheetActivityCategoryId).FirstOrDefault();
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

		public MessageEnum TimesheetActivityCategoryUpdate(TimesheetActivityCategoryDTO timesheetActivityCategoryDTO)
		{
			try
			{
				var timesheetActivityCategory = _Context.TimesheetActivityCategories.Where(x => x.TimesheetActivityCategoryId != timesheetActivityCategoryDTO.TimesheetActivityCategoryId  && x.TimesheetActivityCategoryName == timesheetActivityCategoryDTO.TimesheetActivityCategoryName && x.Deleted == false).FirstOrDefault();
				if (timesheetActivityCategory == null)
				{
					var a = _Context.TimesheetActivityCategories.Where(x => x.TimesheetActivityCategoryId == timesheetActivityCategoryDTO.TimesheetActivityCategoryId).FirstOrDefault();
					if (a != null)
					{
						a.TimesheetActivityCategoryName = timesheetActivityCategoryDTO.TimesheetActivityCategoryName;
						a.UpdatedBy = timesheetActivityCategoryDTO.CreatedBy;
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

		public TimesheetActivityCategory GetTimesheetActivityCategoryByTimesheetActivityCategoryId(int timesheetActivityCategoryId)
		{

			try
			{
				return _Context.TimesheetActivityCategories.Where(x => x.TimesheetActivityCategoryId == timesheetActivityCategoryId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}
	}
}
