using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.DesktopMonitoring
{
    public class DesktopSnapsDTO
    {
        public Int64? DesktopActivityLogId { get; set; }
        public Int64? DesktopLoginId { get; set; }
        public Int64? EmployeeId { get; set; }
        public string? LogType { get; set; }
        public string? SnapShot { get; set; }
        public DateTime? SnapshotDateTime { get; set; }
        public Double? FileSize { get; set; }
        public Int64 CreatedBy { get; set; }
        public IFormFile? imageUpload { get; set; }

    }
}
