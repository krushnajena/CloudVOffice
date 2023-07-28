using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Data.ViewModel.DesktopMonitering;
using CloudVOffice.Services.Emp;
using Humanizer;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public class DesktoploginSevice : IDesktoploginSevice
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<DesktopLogin> _desktopLoginRepo;
        private readonly IEmployeeService _employeeService;
        public DesktoploginSevice(ApplicationDBContext Context, ISqlRepository<DesktopLogin> desktopLoginRepo,
             IEmployeeService employeeService
            )
        {

            _Context = Context;
            _desktopLoginRepo = desktopLoginRepo;
            _employeeService = employeeService;
        }
        public DesktopLogin DesktoploginCreate(DesktopLoginDTO desktoploginDTO)
        {
            try
            {
                var desktoplogincreate = _Context.DesktopLogins.Where(x => x.EmployeeId == desktoploginDTO.EmployeeId && x.Deleted == false && x.IsActiveSession == true && x.ComputerName == desktoploginDTO.ComputerName).OrderByDescending(x=>x.DesktopLoginId).FirstOrDefault();
                if (desktoplogincreate != null)
                {
                    desktoplogincreate.IsActiveSession = false;
                    _Context.SaveChanges();
                }

                
                 var a=   _desktopLoginRepo.Insert(new DesktopLogin()
                    {
                        EmployeeId = desktoploginDTO.EmployeeId,
                        LoginDateTime=desktoploginDTO.LoginDateTime,
                        ComputerName = desktoploginDTO.ComputerName,
                        IpAddress = desktoploginDTO.IpAddress,
                        LogOutDateTime=DateTime.Now,         
                        IsActiveSession=true,
                        SyncedOn=DateTime.Now,
                        CreatedBy = desktoploginDTO.CreatedBy,
                        CreatedDate = DateTime.Now,
                        Deleted = false
                    });
                    return a;
               
            }
            catch
            {
                throw;
            }
        }

        public MessageEnum DesktopLoginDelete(Int64 DesktopLoginId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.DesktopLogins.Where(x => x.DesktopLoginId == DesktopLoginId).FirstOrDefault();
                if (a != null)
                {
                    a.Deleted = true;
                    a.UpdatedBy = DeletedBy;
                    a.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();
                    return MessageEnum.Deleted;
                }
                else
                    return MessageEnum.Invalid;
            }
            catch
            {
                throw;
            }

        }

        public MessageEnum DesktopLoginUpdateIdelTime(DesktopLoginIdelTimeUpdateDTO desktopLoginIdelTimeUpdateDTO)
        {
            try
            {
                var a = _Context.DesktopLogins.Where(x => x.DesktopLoginId == desktopLoginIdelTimeUpdateDTO.DesktopLoginId).FirstOrDefault();
                if (a != null)
                {
                    a.IdelTime = desktopLoginIdelTimeUpdateDTO.IdelTime;
                    _Context.SaveChanges();
                    return MessageEnum.Success;
                }
                else
                    return MessageEnum.Invalid;
            }
            catch
            {
                throw;
            }
        }

        public DesktopLogin GetDesktoploginByDesktoploginId(Int64 DesktopLoginId)
        {
            try
            {
                return _Context.DesktopLogins.Where(x => x.DesktopLoginId == DesktopLoginId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<DesktopLogin> GetDesktoploginsWithDateRange(DesktopLoginFilterDTO desktopLoginFilterDTO)
        {
            try
            {
               
               var a =  _Context.DesktopLogins
                      .Include(x=>x.Employee)
                    .Where(x => x.Deleted == false &&
                                                          x.EmployeeId == desktopLoginFilterDTO.EmployeeId &&
                                                          x.LoginDateTime >= desktopLoginFilterDTO.FromDate &&
                                                          x.LoginDateTime <= desktopLoginFilterDTO.ToDate

                                                          ).OrderByDescending(x=>x.LoginDateTime).ToList();

            

                return a;

            }
            catch
            {
                throw;
            }
        }

        public List<DesktopLogin> GetTodayLoginData(Int64 EmployeeId)
        {
            try
            {
                return _Context.DesktopLogins.Where(x => x.EmployeeId == EmployeeId && x.Deleted == false && (x.LoginDateTime  >= System.DateTime.Today && x.LoginDateTime < System.DateTime.Today.AddDays(1))).OrderBy(x => x.LoginDateTime).ToList();
            }
            catch { throw; }
        }
    }
}
