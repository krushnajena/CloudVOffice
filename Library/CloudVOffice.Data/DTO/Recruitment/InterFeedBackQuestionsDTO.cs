using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Recruitment
{
	public class InterFeedBackQuestionsDTO
	{
		public int InterFeedBackQuestionsId { get; set; }
		public int? DesignationId { get; set; }
		public string Question { get; set; }
		public int Mark { get; set; }
		public Int64 CreatedBy { get; set; }
	}
}
