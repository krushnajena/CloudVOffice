using CloudVOffice.Core.Domain.EmailTemplates;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.EmailTemplates
{
	public class EmailTemplateService : IEmailTemplateService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<EmailTemplate> _emailRepo;
		public EmailTemplateService(ApplicationDBContext Context, ISqlRepository<EmailTemplate> emailRepo)
		{

			_Context = Context;
			_emailRepo = emailRepo;
		}
		
		public EmailTemplate GetEmailTemplateByName(string name)
		{
			try
			{
				return _Context.EmailTemplates.Where(x=>x.EmailTemplateName== name && x.Deleted == false ).FirstOrDefault();	
			}
			catch
			{
				throw;
			}
		}
	}
}
