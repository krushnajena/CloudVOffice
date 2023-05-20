using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Comunication
{
	public class EmailAccountDTO
	{
		public int EmailAccountId { get; set; }

		public string EmailAddress { get; set; }
		public int Domain { get; set; }
		public string EmailAccountName { get; set; }
		public string EmailPassword { get; set; }
		public string AlternativeEmailAddress { get; set; }

		public string EmailSignature { get; set; }
		public string EmailLogo { get; set; }
		public bool IsDefaultSending { get; set; }
		public Int64 CreatedBy { get; set; }
	}
}
