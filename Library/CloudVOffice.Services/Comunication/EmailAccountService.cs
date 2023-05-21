using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Comunication;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Comunication;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Pipelines.Sockets.Unofficial.Arenas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Comunication
{
	public class EmailAccountService : IEmailAccountService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<EmailAccount> _emailAccountRepo;
		public EmailAccountService(ApplicationDBContext Context, ISqlRepository<EmailAccount> emailAccountRepo)
		{

			_Context = Context;
			_emailAccountRepo = emailAccountRepo;
		}
		public MennsageEnum EmailAccountCreate(EmailAccountDTO emailAccountDTO)
		{
			var objCheck = _Context.EmailAccounts.SingleOrDefault(opt => opt.EmailAccountId == emailAccountDTO.EmailAccountId && opt.Deleted == false);
			try
			{
				if (objCheck == null)
				{

					EmailAccount emailAccount = new EmailAccount();
					emailAccount.EmailAddress = emailAccountDTO.EmailAddress;
					emailAccount.Domain = emailAccountDTO.Domain;
					emailAccount.EmailAccountName = emailAccountDTO.EmailAccountName;
					emailAccount.EmailPassword = emailAccountDTO.EmailPassword;
					emailAccount.AlternativeEmailAddress = emailAccountDTO.AlternativeEmailAddress;
					emailAccount.EmailSignature = emailAccountDTO.EmailSignature;
					emailAccount.EmailLogo = emailAccountDTO.EmailLogo;
					emailAccount.IsDefaultSending = emailAccountDTO.IsDefaultSending;
					emailAccount.CreatedBy = emailAccountDTO.CreatedBy;
					var obj = _emailAccountRepo.Insert(emailAccount);

					return MennsageEnum.Success;
				}
				else if (objCheck != null)
				{
					return MennsageEnum.Duplicate;
				}

				return MennsageEnum.UnExpectedError;
			}
			catch
			{
				throw;
			}
		}

		public MennsageEnum EmailAccountDelete(int emailAccountId, int DeletedBy)
		{
			try
			{
				var a = _Context.EmailAccounts.Where(x => x.EmailAccountId == emailAccountId).FirstOrDefault();
				if (a != null)
				{
					a.Deleted = true;
					a.UpdatedBy = DeletedBy;
					a.UpdatedDate = DateTime.Now;
					_Context.SaveChanges();
					return MennsageEnum.Deleted;
				}
				else
					return MennsageEnum.Invalid;
			}
			catch
			{
				throw;
			}
		}

		public MennsageEnum EmailAccountUpdate(EmailAccountDTO emailAccountDTO)
		{
			try
			{
				var project = _Context.EmailAccounts.Where(x => x.EmailAccountId == emailAccountDTO.EmailAccountId && x.Deleted == false).FirstOrDefault();
				if (project == null)
				{
					var a = _Context.EmailAccounts.Where(x => x.EmailAccountId == emailAccountDTO.EmailAccountId).FirstOrDefault();
					if (a != null)
					{
						a.EmailAddress = emailAccountDTO.EmailAddress;
						a.Domain = emailAccountDTO.Domain;
						a.EmailAccountName = emailAccountDTO.EmailAccountName;
						a.EmailPassword = emailAccountDTO.EmailPassword;
						a.AlternativeEmailAddress = emailAccountDTO.AlternativeEmailAddress;
						a.EmailSignature = emailAccountDTO.EmailSignature;
						a.EmailLogo = emailAccountDTO.EmailLogo;
						a.IsDefaultSending = emailAccountDTO.IsDefaultSending;
						
						a.UpdatedDate = DateTime.Now;
						_Context.SaveChanges();
						return MennsageEnum.Updated;
					}
					else
						return MennsageEnum.Invalid;
				}
				else
				{
					return MennsageEnum.Duplicate;
				}

			}
			catch
			{
				throw;
			}
		}

		public EmailAccount GetEmailAccountByEmailAccountId(int emailAccountId)
		{
			try
			{
				return _Context.EmailAccounts.Where(x => x.EmailAccountId == emailAccountId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public EmailAccount GetEmailAccountByEmailAccountName(string emailAccountName)
		{
			try
			{
				return _Context.EmailAccounts.Where(x => x.EmailAccountName == emailAccountName && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		

		public List<EmailAccount> GetEmailAccounts()
		{
			try
			{
				return _Context.EmailAccounts.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}
	}

	
}
