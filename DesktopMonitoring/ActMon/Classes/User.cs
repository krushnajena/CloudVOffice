using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DesktopMonitoringSystem.Classes
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }     
        public string ApplicantName { get; set; }
       
    }

    public class UserLoginDetails
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? SubUserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ApplicantName { get; set; }
        public string UserType { get; set; }
        public int? UserTypeId { get; set; }
        public int? RoleId { get; set; }
        public int? UserLoginId { get; set; }
        public int? IsPasswordChange { get; set; }
        public int? MineralId { get; set; }
        public string MineralName { get; set; }
        public string UserRoleInfo { get; set; }
        public string MobileNumber { get; set; }
        public string EmailID { get; set; }
        public bool IsSubUser { get; set; }
        public int TPOffline { get; set; }
        public string DistrictName { get; set; }
        public bool IsOnlyTP { get; set; }
        public int? LeaseStatusId { get; set; }
        public string LesseeStatus { get; set; }
        public string MineralTypeName { get; set; }
        public string IsSidePanelHide { get; set; }
        public string NoticeFilePath { get; set; }
        public int? IsLowGradeLimestone { get; set; }
        public string SMS_SENT { get; set; }
        
        public string EncryptPassword { get; set; }


        public string Desigination { get; set; }
        public int? DesiginationId { get; set; }
        public int? deptid { get; set; }
        public int? int_LevelId { get; set; }
  
        public string VCH_DISECODE { get; set; }
        public int int_DesignationId { get; set; }
        public string DistrictId { get; set; }

        public string UserImage { get; set; }
    }
}
