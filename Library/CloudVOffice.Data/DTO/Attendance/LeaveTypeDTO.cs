namespace CloudVOffice.Data.DTO.Attendance
{
    public class LeaveTypeDTO
    {
        public int? LeaveTypeId { get; set; }
        public string LeaveTypeName { get; set; }
        public int? MaximumLeaveAllocationAllowed { get; set; }
        public int? ApplicableAfterWorkingDays { get; set; }
        public int? MaximumConsecutiveLeavesAllowed { get; set; }
        public bool IsCarryForward { get; set; }
        public int? MaximumCarryForwardedLeaves { get; set; }
        public int? ExpireCarryForwardedLeaves { get; set; }

        public bool IsLeaveWithoutPay { get; set; }
        public bool IsPartiallyPaidLeave { get; set; }
        public bool IsOptionalLeave { get; set; }
        public bool AllowNegativeBalance { get; set; }
        public bool AllowOverAllocation { get; set; }
        public bool IsCompensatory { get; set; }
        public bool AllowEncashment { get; set; }

        public int? EncashmentThresholdDays { get; set; }
        public int? EarningSalaryComponentId { get; set; }
        public bool IsEarnedLeave { get; set; }
        public string? EarnedLeaveFrequency { get; set; }
        public bool BasedOnDateOfJoining { get; set; }
        public double? Rounding { get; set; }



        public Int64 CreatedBy { get; set; }
    }
}
