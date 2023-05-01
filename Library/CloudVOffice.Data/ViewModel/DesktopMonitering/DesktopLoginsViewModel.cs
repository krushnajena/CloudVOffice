using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.ViewModel.DesktopMonitering
{
    public class DesktopLoginsViewModel
    {
        public int DesktopLoginId { get; set; }
        public int UserId { get; set; }

        public DateTime LoginDateTime { get; set; }
        public DateTime? LogOutDateTime { get; set; }
        public bool IsAutoLogedOut { get; set; }
        public bool IsActiveSession { get; set; }
        public DateTime? SyncedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public string UserName { get; set; }
        public string ApplicantName { get; set; }
        public string ComputerName { get; set; }
        public string IpAddress { get; set; }
        public string Duration { get; set; }
        public string IdelDuration { get; set; }
    }
}
