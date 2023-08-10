namespace CloudVOffice.Data.DTO.Projects
{
    public class TaskAssignmentDTO
    {
        public Int64 TaskAssignmentId { get; set; }
        public Int64 TaskId { get; set; }
        public Int64 EmployeeId { get; set; }
        public Int64 AssignedBy { get; set; }
        public DateTime? AssignedOn { get; set; }
        public Int64? CompliteBy { get; set; }
        public DateTime? ActualCompliteOn { get; set; }
        public string? DelayReason { get; set; }
        public bool IsDelayApproved { get; set; }
        public Int64? DelayApprovedBy { get; set; }
        public DateTime? DelayApprovedOn { get; set; }

        public Int64 CreatedBy { get; set; }
    }
}
