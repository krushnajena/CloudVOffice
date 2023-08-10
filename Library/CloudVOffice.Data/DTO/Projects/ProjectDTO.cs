namespace CloudVOffice.Data.DTO.Projects
{
    public class ProjectDTO
    {
        public int? ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? EffortHourRequired { get; set; }
        public string Status { get; set; }
        public int ProjectTypeId { get; set; }
        public string Priority { get; set; }
        public string CompleteMethod { get; set; }
        public int? CustomerId { get; set; }
        public Int64? SalesOrderId { get; set; }
        public string ProjectNotes { get; set; }
        public double? EstimatedCost { get; set; }
        public Int64? ProjectManager { get; set; }
        public Int64 CreatedBy { get; set; }

        public List<ProjectEmployeeDTO>? ProjectEmployees { get; set; }
        public string ProjectEmployeeString { get; set; }

        public List<ProjectUserDTO>? ProjectUsers { get; set; }
        public string ProjectUsersString { get; set; }


    }

    public class ProjectEmployeeDTO
    {

        public Int64 EmployeeId { get; set; }
        public int? ProjectId { get; set; }
        public string FullName { get; set; }
        public Int64? CreatedBy { get; set; }
    }
}
