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
		public MessageEnum EmailDomainCreate(EmailDomainDTO emailDomainDTO);
		public List<EmailDomain> GetEmailDomains();
		public EmailDomain GetEmailDomainByEmailDomainId(int emailDomainId);
		public MessageEnum EmailDomainUpdate(EmailDomainDTO emailDomainDTO);
		public MessageEnum EmailDomainDelete(int emailDomainId, int DeletedBy);
	}
}
