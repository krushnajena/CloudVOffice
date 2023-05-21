using CloudVOffice.Core.Domain.EmailTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.EmailTemplates
{
	public interface IEmailTemplateService
	{
		public EmailTemplate GetEmailTemplateByName(string name);
	}
}
