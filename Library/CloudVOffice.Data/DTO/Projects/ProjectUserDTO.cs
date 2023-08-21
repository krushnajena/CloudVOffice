namespace CloudVOffice.Data.DTO.Projects
{
    public class ProjectUserDTO
    {
        public Int64? ProjectUserId { get; set; }
        public int? ProjectId { get; set; }
        public Int64 UserId { get; set; }
        public string FullName { get; set; }

        public Int64? CreatedBy { get; set; }
    }
}
