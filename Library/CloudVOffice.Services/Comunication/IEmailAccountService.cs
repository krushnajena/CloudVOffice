using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Comunication;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Comunication;
using CloudVOffice.Data.DTO.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Comunication
{
	public interface IEmailAccountService
	{
		public MennsageEnum EmailAccountCreate(EmailAccountDTO emailAccountDTO);
		public List<EmailAccount> GetEmailAccounts();
		public EmailAccount GetEmailAccountByEmailAccountId(int emailAccountId);
		public EmailAccount GetEmailAccountByEmailAccountName(string emailAccountName);
		public MennsageEnum EmailAccountUpdate(EmailAccountDTO emailAccountDTO);
		public MennsageEnum EmailAccountDelete(int emailAccountId, int DeletedBy);

		
	}
}
