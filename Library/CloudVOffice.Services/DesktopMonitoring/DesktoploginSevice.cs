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
        public MessageEnum DesktoploginCreate(DesktopLoginDTO desktoploginDTO)
        {
            try
            {
                var desktoplogincreate = _Context.DesktopLogins.Where(x => x.EmployeeId == desktoploginDTO.EmployeeId && x.Deleted == false).FirstOrDefault();
                if (desktoplogincreate == null)
                {
                    _desktopLoginRepo.Insert(new DesktopLogin()
                    {
                        EmployeeId = desktoploginDTO.EmployeeId,
                        LoginDateTime=desktoploginDTO.LoginDateTime,
                        LogOutDateTime=desktoploginDTO.LogOutDateTime,
                        IsAutoLogedOut=desktoploginDTO.IsAutoLogedOut,                       
                        IsActiveSession=false,
                        SyncedOn=desktoploginDTO.SyncedOn,
                        CreatedBy = desktoploginDTO.CreatedBy,
                        CreatedDate = DateTime.Now,
                        Deleted = false
                    });
                    return MessageEnum.Success;
                }
                else
                    return MessageEnum.Duplicate;
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

        public MessageEnum DesktopLoginUpdate(DesktopLoginDTO desktoploginDTO)
        {
            try
            {
                var desktopLogin = _Context.DesktopLogins.Where(x => x.DesktopLoginId != desktoploginDTO.DesktopLoginId && x.EmployeeId == desktoploginDTO.EmployeeId && x.Deleted == false).FirstOrDefault();
                if (desktopLogin == null)
                {
                    var a = _Context.DesktopLogins.Where(x => x.DesktopLoginId == desktoploginDTO.DesktopLoginId).FirstOrDefault();
                    if (a != null)
                    {
                        a.EmployeeId = desktoploginDTO.EmployeeId;
                        a.LoginDateTime=desktoploginDTO.LoginDateTime;
                        a.LogOutDateTime=desktoploginDTO.LogOutDateTime;
                        a.IsActiveSession=desktoploginDTO.IsActiveSession;
                        a.IsAutoLogedOut=desktoploginDTO.IsAutoLogedOut;
                        a.SyncedOn=desktoploginDTO.SyncedOn;
                        a.UpdatedBy = desktoploginDTO.CreatedBy;
                        a.UpdatedDate = DateTime.Now;
                        _Context.SaveChanges();
                        return MessageEnum.Updated;
                    }
                    else
                        return MessageEnum.Invalid;
                }
                else
                {
                    return MessageEnum.Duplicate;
                }

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

        public List<DesktopLoginsViewModel> GetDesktoplogins(DesktopLoginFilterDTO desktopLoginFilterDTO)
        {
            try
            {
                List<DesktopLoginsViewModel> loginsViewModels= new List<DesktopLoginsViewModel>();
               var a =  _Context.DesktopLogins.Where(x => x.Deleted == false &&
                                                          x.EmployeeId == desktopLoginFilterDTO.EmployeeId &&
                                                          x.LoginDateTime >= desktopLoginFilterDTO.FromDate &&
                                                          x.LoginDateTime <= desktopLoginFilterDTO.ToDate

                                                          ).ToList();

                    var Employee = _employeeService.GetEmployeeById(desktopLoginFilterDTO.EmployeeId);

                for(int i=0;i< a.Count; i++)
                {

                    var dateOne = a[i].LogOutDateTime;
                    var dateTwo = a[i].LoginDateTime;
                    var res = "";
                    if (dateOne != null)
                    {
                        var diff = DateTime.Parse( dateTwo.ToString()).Subtract( DateTime.Parse( dateOne.ToString()));
                        res = String.Format("{0}:{1}:{2}", diff.Hours, diff.Minutes, diff.Seconds);
                    }


                    loginsViewModels.Add(new DesktopLoginsViewModel{
                        EmployeeName = Employee.FullName,
                        ComputerName = a[i].ComputerName,
                        IpAddress = a[i].IpAddress,
                        LogDate = a[i].LoginDateTime.Value.Date,
                        LoginDateTime = a[i].LoginDateTime,
                        LogOutDateTime = a[i].LogOutDateTime,
                        Duration = res,
                        IdelDuration = a[i].IdelTime.ToString(),
                        EmployeeId = a[i].EmployeeId,
                        DesktopLoginId = a[i].DesktopLoginId
                    }
                    

                        ) ;
                }


                return loginsViewModels;

            }
            catch
            {
                throw;
            }
        }
    }
}
