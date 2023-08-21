using Azure.Storage.Blobs.Models;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public class DesktopKeystrokeService : IDesktopKeystrokeService
    {
        private readonly ApplicationDBContext _Context;

        private readonly ISqlRepository<DesktopKeyStroke> _desktopKeyStrokesRepo;
        public DesktopKeystrokeService(ApplicationDBContext Context,
             ISqlRepository<DesktopKeyStroke> desktopKeyStrokesRepo)
        {
            _Context = Context;
            _desktopKeyStrokesRepo = desktopKeyStrokesRepo;
        }
        public List<DesktopKeyStroke> DesktopKeystrokeLogsWithFilter(DesktopLoginFilterDTO desktopLoginFilterDTO)
        {
            return _Context.DesktopKeyStrokes.Include(x => x.DesktopActivityLog).ThenInclude(X => X.DesktopSnapshots)
                .Where(x => x.Deleted == false && x.DesktopActivityLog.EmployeeId == desktopLoginFilterDTO.EmployeeId
                && (x.KeyStrokeDateTime >= desktopLoginFilterDTO.FromDate && x.KeyStrokeDateTime <= desktopLoginFilterDTO.ToDate)

                ).OrderByDescending(l => l.KeyStrokeDateTime).ToList();
        }
        public MessageEnum AddDesktopKeystrokes(DesktopKeyStrokesDTO desktopKeyStrokesDTO)
        {
            _desktopKeyStrokesRepo.Insert(new DesktopKeyStroke
            {
                LogType = "Key",
                DesktopActivityLogId = desktopKeyStrokesDTO.DesktopActivityLogId,
                Keystrokes = desktopKeyStrokesDTO.Keystrokes,
                KeyStrokeDateTime = DateTime.Now,
                SyncedOn = DateTime.Now,
                CreatedBy =Int64.Parse( desktopKeyStrokesDTO.CreatedBy.ToString()),
                CreatedDate = DateTime.Now,
                Deleted = false,
            });
            return MessageEnum.Success;
        }
    }
}
