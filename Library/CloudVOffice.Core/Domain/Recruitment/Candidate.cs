using CloudVOffice.Core.Domain.HR.Master;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Recruitment
{
    public class Candidate : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 CandidateId { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }  
        public string? LastName { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                if (MiddleName != null && MiddleName != "")
                {
                    return FirstName + " " + MiddleName + " " + LastName;
                }
                else
                { return FirstName + " " + LastName; }

            }
        }
        public string? Email { get; set; }
        public string? MobileNo { get; set; }
        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public double? ExperienceinYears { get; set; }
        public string  HighestQualification { get; set; }
        public string? CurrentJob { get;set; }
        public string? CurrentEmployer { get; set; }
        public double? ExpectedSalary { get; set; }
        
        public double? CurrentSalary { get; set; }
        public string Cv { get; set; }
        public int? ApplicationSourceId { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        public int Status { get; set; } = 1; //1=New, 2=Blacklisted , 3= Hired,4= Rejected,5 = Offered

        [ForeignKey("ApplicationSourceId")]
        public JobApplicationSource JobApplicationSource{ get; set; }




    }
}
