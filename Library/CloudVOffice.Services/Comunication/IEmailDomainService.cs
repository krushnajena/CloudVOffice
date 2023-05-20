using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Comunication;
using CloudVOffice.Data.DTO.Comunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Comunication
{
	
	public	interface IEmailDomainService
	{
		public MennsageEnum EmailDomainCreate(EmailDomainDTO emailDomainDTO);
		public List<EmailDomain> GetEmailDomains();
		public EmailDomain GetEmailDomainByEmailDomainId(int emailDomainId);
		public MennsageEnum EmailDomainUpdate(EmailDomainDTO emailDomainDTO);
		public MennsageEnum EmailDomainDelete(int emailDomainId, int DeletedBy);
	}
}
