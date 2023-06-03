using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.HR.Master
{
    public class DesignationService : IDesignationService
    {
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<Designation> _designationRepo;
		public DesignationService(ApplicationDBContext Context, ISqlRepository<Designation> designationRepo)
		{

			_Context = Context;
			_designationRepo = designationRepo;
		}

		public MessageEnum CreateDesignation(DesignationDTO designationDTO)
		{
			try
			{
				var brach = _Context.Designations.Where(x => x.DesignationName == designationDTO.DesignationName && x.Deleted == false).FirstOrDefault();
				if (brach == null)
				{
					_designationRepo.Insert(new Designation()
					{
						DesignationName = designationDTO.DesignationName,
						Description= designationDTO.Description,
						CreatedBy = designationDTO.CreatedBy,
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

		public MessageEnum DesignationDelete(Int64 designationId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.Designations.Where(x => x.DesignationId == designationId).FirstOrDefault();
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

		public MessageEnum DesignationUpdate(DesignationDTO designationDTO)
		{
			try
			{
				var branch = _Context.Designations.Where(x => x.DesignationId != designationDTO.DesignationId && x.DesignationName == designationDTO.DesignationName && x.Deleted == false).FirstOrDefault();
				if (branch == null)
				{
					var a = _Context.Designations.Where(x => x.DesignationId == designationDTO.DesignationId).FirstOrDefault();
					if (a != null)
					{
						a.DesignationName = designationDTO.DesignationName;
						a.Description = designationDTO.Description;
						a.UpdatedBy = designationDTO.CreatedBy;
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

		public Designation GetDesignationById(Int64 designationId)
		{
			try
			{
				return _Context.Designations.Where(x => x.DesignationId == designationId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public List<Designation> GetDesignationList()
		{
			try
			{
				return _Context.Designations.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}
	}
}
