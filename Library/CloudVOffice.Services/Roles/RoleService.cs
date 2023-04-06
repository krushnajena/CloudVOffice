using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Data.DTO.Roles;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using LinqToDB;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Role = CloudVOffice.Core.Domain.Users.Role;

namespace CloudVOffice.Services.Roles
{
    public class RoleService: IRoleService
    {
        private readonly ApplicationDBContext _context;
        private readonly ISqlRepository<Role> _RoleRepo;

        public RoleService(ApplicationDBContext context, ISqlRepository<Role> RoleRepo)
        {
            _context = context;
            _RoleRepo = RoleRepo;
        }

        public string InsertRole(string rolename)
        {
            var objCheck = _context.Roles.SingleOrDefault(opt => opt.RoleName == rolename);
            try
            {
                if (objCheck == null)
                {
                    Role role = new Role();
                    role.RoleName = rolename;
                    var obj = _RoleRepo.Insert(role);
                    return "Role Sucessfully Created";
                }
                else if (objCheck == null)
                {
                    return "Duplicate";
                }
                return "Something unexpected!";
            }
            catch (Exception ex)
            {
                return "Error!";
            }
        }
        /*public string GetRoleList()
        {
            try
            {
                var list = (from u in _context.Roles
                            select new
                            {
                                u.RoleId,
                                u.RoleName,
                                u.CreatedOn,
                            });
                int totalRecord = list.Count();
                return "Role Sucessfully View";
            }
            catch (Exception ex)
            {
                return "Error";
            }
        }*/

        public List<Role> GetAllBranch()
        {
            return _context.Roles.Where(x => x. == false).ToList();
        }

        public string UpdateRole(int roleid, string rolename)
        {
            try
            {
                var objrole = _context.Roles.SingleOrDefault(opt => opt.RoleId == roleid);
                objrole.RoleName = rolename;
                objrole.CreatedOn = DateTime.Now;
                _context.SaveChanges();
                return "Role Sucessfully Updated";
            }
            catch (Exception ex)
            {
                return "Error";
            }
        }

        //public string DeleteRole(int roleid)
        //{
        //    try
        //    {
        //        var obj = _context.Roles.SingleOrDefault(opt => opt.RoleId == roleid);
        //        _context.SaveChanges();
        //        return "Role Sucessfully Deleted";
        //    }
        //    catch (Exception ex)
        //    {
        //        return "Error";
        //    }
        //}

        public Role GetRoleinsingleid(int roleid)
        {
            try
            {
                var SingleRole = _RoleRepo.SelectById(roleid);

                return SingleRole;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public Role DeleteRole(int roleid)
        {
            try
            {
                var obj = _context.Roles.SingleOrDefault(opt => opt.RoleId == roleid);
                _context.SaveChanges();
                return obj;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
