using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Data.DTO.Roles;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Roles
{
    public interface IRoleService
    {
        public string InsertRole(string rolename);

        /*public string GetRoleList();*/
        public List<Role> GetAllBranch();

        public Role GetRoleinsingleid(int roleid);
        public string UpdateRole(int roleid, string rolename);
        public Role DeleteRole(int roleid);
    }
}
