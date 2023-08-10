namespace CloudVOffice.Data.DTO.HR
{

    public class HRSettingsDTO
    {

        public int? HRSettingsId { get; set; }
        public double? StandardWorkingHours { get; set; }
        public double? BreakHours { get; set; }
        public int? RetirementAge { get; set; }
        public bool SendBirthdaysReminder { get; set; }
        public bool SendWorkAnniversariesReminder { get; set; }
        public bool SendInterviewReminder { get; set; }
        public bool SendInterviewFeedbackReminder { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
