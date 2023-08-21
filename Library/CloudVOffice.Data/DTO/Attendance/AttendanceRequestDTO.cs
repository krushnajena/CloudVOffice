namespace CloudVOffice.Data.DTO.Attendance
{
    public class AttendanceRequestDTO
    {
        public Int64? AttendanceRequestId { get; set; }
        public Int64 EmployeeId { get; set; }
        public DateTime? ForDate { get; set; }
        public TimeSpan CheckInTime { get; set; }
        public TimeSpan CheckOutTime { get; set; }
        public string Reason { get; set; }
        public int ApprovalStatus { get; set; }//0=Submitted ,1 = Approved,2= Rejected
        public Int64? ApprovedBy { get; set; }
        public string? ApprovalRemarks { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public Int64 CreatedBy { get; set; }

    }
    public class AttendanceApprovedDTO
    {
        public Int64 AttendanceRequestId { get; set; }
        public int ApprovalStatus { get; set; }
        public string ApprovalRemarks { get; set; }
        public Int64 AttendanceApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public Int64 UpdatedBy { get; set; }
    }
}