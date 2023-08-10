using ActivityMonitor.Application;
using ActivityMonitor.ApplicationImp;
using ActivityMonitor.ApplicationMonitor;
using ActMon.Utils;
using DesktopMonitoringSystem.Classes;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ActMon.Database
{
    public class DB
    {
        // private SqlConnection conn;
        private string _dbServer;
        private string _dbUsername;
        private string _dbDatabase;
        private string _dbPassword;

        private bool _leaveConnectionOpen;
        private bool _isActLogRunning;

        public DB(int connectionTimeout = 1)
        {


            // conn = new SqlConnection("Data Source=DESKTOP-DFU5PTJ;Initial Catalog=dms;User id=sa;Password=Software@2016");
        }






        public async Task<bool> RecordSession(AppMonitor appMon)
        {
            _leaveConnectionOpen = true;

            await RecordUserSession(appMon.Session);

            try
            {
                foreach (FileLog f in appMon.FileLogs)
                {
                    RecordFileLog(appMon.Session.SessionID, f, appMon.Session.ComputerName);
                }
            }
            catch
            {

            }
            try
            {
                foreach (Application lApp in appMon.Applications)
                {
                    // RecordApplication(lApp);
                    RecordApplicationSession(appMon.Session.SessionID, lApp, (int)appMon.Session.UserID, appMon.Session.ComputerName);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return true;
            }
            _leaveConnectionOpen = false;

            return true;
        }

        public async Task<bool> RecordFileLog(long SessionId, FileLog fileLog, string ComputerName)
        {
            if (fileLog.IsSynced == false)
            {
                DesktopActivityLogDTO dMSActivityLog = new DesktopActivityLogDTO();
                dMSActivityLog.DesktopLoginId = (Int64)SessionId;
                dMSActivityLog.EmployeeId = 0;
                dMSActivityLog.LogDateTime = fileLog.LogDateTime;
                dMSActivityLog.ComputerName = ComputerName;
                dMSActivityLog.ProcessOrUrl = "";
                dMSActivityLog.AppOrWebPageName = "";
                dMSActivityLog.TypeOfApp = "File";
                dMSActivityLog.CreatedBy = 0;
                dMSActivityLog.LogType = "FileLog";
                dMSActivityLog.Todatetime = fileLog.LogDateTime;
                dMSActivityLog.Action = fileLog.Action;
                dMSActivityLog.Source = fileLog.Source;
                dMSActivityLog.Folder = fileLog.Destination;

                var a = await HttpClientRq.PostRequest(ApiUrls.postActivityLog, JsonConvert.SerializeObject(dMSActivityLog));
                fileLog.UpdateSyncTime();
                return true;
            }
            else { return false; }

        }

        public async Task<bool> RecordApplicationSession(long SessionID, Application sApp, int UserId, string ComputerName)
        {
            string sqlStr;
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            //        // Combine the base folder with your specific folder....
            string specificFolder = Path.Combine(folder, "DMSSnaps");
            for (int i = 0; i < sApp.Usage.Count; i++)
            {
                if (sApp.Usage[i].IsClosed == true && sApp.Usage[i].IsSynced == false)
                {
                    DesktopActivityLogDTO dMSActivityLog = new DesktopActivityLogDTO();
                    dMSActivityLog.DesktopLoginId = (Int64)SessionID;
                    dMSActivityLog.EmployeeId = 0;
                    dMSActivityLog.LogDateTime = sApp.Usage[i].BeginTime;
                    dMSActivityLog.ComputerName = ComputerName;
                    dMSActivityLog.ProcessOrUrl = sApp.ExeName;
                    dMSActivityLog.AppOrWebPageName = sApp.Usage[i].DetailedName;
                    dMSActivityLog.TypeOfApp = "App";
                    dMSActivityLog.CreatedBy = 0;
                    dMSActivityLog.LogType = "ActivityLog";
                    dMSActivityLog.Todatetime = sApp.Usage[i].EndTime;
                    var a = await HttpClientRq.PostRequest(ApiUrls.postActivityLog, JsonConvert.SerializeObject(dMSActivityLog));
                    if (a.StatusCode == HttpStatusCode.OK)
                    {

                        //   uSession.SessionID = 1;

                        var X = a.Content.ReadAsStringAsync()
                                                                 .Result
                                                                 //.Replace("\\", "")
                                                                 //.Replace("\r\n", "'")
                                                                 .Trim(new char[1] { '"' });
                        var json = JsonConvert.DeserializeObject<
                        DesktopActivityLogViewModel>(X);
                        if (json != null)
                        {

                            for (int j = 0; j < sApp.Usage[i].ScreenShots.Count; j++)
                            {

                                var b = await HttpClientRq.UploadFilesAsync(ApiUrls.imageUpload, specificFolder + @"\" + sApp.Usage[i].ScreenShots[j].ScreenshotName, SessionID.ToString(), json.DesktopActivityLogId.ToString(), (DateTime)sApp.Usage[i].ScreenShots[j].SnapDatetime, "App");


                            }

                        }
                    }
                    //SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
                    //var x = connection.Insert(dMSActivityLog);


                    sApp.Usage[i].UpdateSyncTime(0);

                }

            }
            return true;
            //sqlStr = @"begin tran
            //         if exists(select * from SessionApplicationsUsage with (updlock, serializable) where sessionID=@sessionID AND applicationID = @applicationID)
            //         begin
            //          update SessionApplicationsUsage set usageTime=@usageTime
            //          where sessionID=@sessionID AND applicationID = @applicationID
            //         end
            //         else
            //         begin
            //         insert into SessionApplicationsUsage(sessionID, applicationID, usageTime)
            //         values(@sessionID, @applicationID, @usageTime)
            //         end
            //         commit tran";

            //using (SqlCommand sqlCommand = new SqlCommand())
            //{
            //    sqlCommand.Parameters.AddWithValue("@sessionID", (object)SessionID);
            //    sqlCommand.Parameters.AddWithValue("@applicationID", (object)sApp.ApplicationID);
            //    sqlCommand.Parameters.AddWithValue("@usageTime", (long)sApp.TotalUsageTime.TotalSeconds);

            //    sqlCommand.Connection = conn;
            //    sqlCommand.CommandText = sqlStr;

            //    try
            //    {
            //        openConnection();
            //        sqlCommand.ExecuteNonQuery();
            //        closeConnection();
            //        return true;
            //    }
            //    catch (SqlException ex)
            //    {
            //        return false;
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        return false;
            //    }
            //}
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "";
        }

        public async Task<bool> RecordUserSession(UserSession uSession)
        {
            string sqlStr;


            if (uSession.SessionID == 0)
            {
                DesktopLoginDTO desktopLoginDTO = new DesktopLoginDTO
                {
                    LoginDateTime = uSession.SessionStarted,
                    ComputerName = uSession.ComputerName,
                    IpAddress = GetLocalIPAddress(),
                    SyncedOn = DateTime.Now,
                    EmployeeId = 1,
                    CreatedBy = 1

                };
                var a = await HttpClientRq.PostRequest(ApiUrls.postSessionLog, JsonConvert.SerializeObject(desktopLoginDTO));
                if (a.StatusCode == HttpStatusCode.OK)
                {

                    //   uSession.SessionID = 1;

                    var X = a.Content.ReadAsStringAsync()
                                                             .Result
                                                             //.Replace("\\", "")
                                                             //.Replace("\r\n", "'")
                                                             .Trim(new char[1] { '"' });
                    var json = JsonConvert.DeserializeObject<
                    DesktopLoginViewModel>(X);
                    if (json != null)
                    {
                        uSession.SessionID = json.DesktopLoginId;

                    }
                }

                return true;
            }
            else
            {
                DesktopLoginIdelTimeUpdateDTO desktopLoginIdelTimeUpdateDTO = new DesktopLoginIdelTimeUpdateDTO
                {
                    DesktopLoginId = uSession.SessionID,
                    IdelTime = uSession.IdleTime
                };
                var a = await HttpClientRq.PostRequest(ApiUrls.updateIdelTime, JsonConvert.SerializeObject(desktopLoginIdelTimeUpdateDTO));
                //SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
                //var dmsSessionLog = connection.Query<DmsSessionLog>("select * from DmsSessionLog where Id="+ uSession.SessionID).FirstOrDefault();

                //dmsSessionLog.Id = (int)uSession.SessionID;

                //dmsSessionLog.EndDateTime = uSession.SessionEnded;

                //    dmsSessionLog.IsAutoLogOut = false
                //        ;

                //dmsSessionLog.IdelTime = (int)uSession.IdleTime.TotalSeconds;

                //connection.Update(dmsSessionLog);
                return true;
            }

        }

        public async void SyncSessionLogData()
        {
            //SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
            //var dmsSessionLog = connection.Query<DmsSessionLog>("select * from DmsSessionLog where Id<>(select Max(Id) from DmsSessionLog) and IsSynced=0").ToList();
            //if (dmsSessionLog != null)
            //{
            //    for (int i = 0; i < dmsSessionLog.Count; i++)
            //    {


            //        CreateDesktopLoginDTO createDesktopLoginDTO = new CreateDesktopLoginDTO();
            //        createDesktopLoginDTO.UserId = dmsSessionLog[i].UserId;
            //        createDesktopLoginDTO.LoginDateTime = dmsSessionLog[i].StartTime;
            //        createDesktopLoginDTO.LogOutDateTime = dmsSessionLog[i].EndDateTime;
            //        if (dmsSessionLog[i].EndDateTime == null)
            //        {
            //            createDesktopLoginDTO.IsAutoLogedOut = true;
            //        }
            //        else
            //        {
            //            createDesktopLoginDTO.IsAutoLogedOut = false;
            //        }

            //        createDesktopLoginDTO.SyncedOn = DateTime.Now;
            //        createDesktopLoginDTO.ComputerName = dmsSessionLog[i].MachineName;
            //        createDesktopLoginDTO.IpAddress = dmsSessionLog[i].IpAddress;
            //        createDesktopLoginDTO.CreatedBy = dmsSessionLog[i].UserId;
            //        if (dmsSessionLog[i].IdelTime == null)
            //        {
            //            createDesktopLoginDTO.IdelTime = 0;
            //        }
            //        else
            //        {
            //            createDesktopLoginDTO.IdelTime = (int)dmsSessionLog[i].IdelTime;
            //        }

            //        var a = await HttpClientRq.PostRequest(ApiUrls.postSessionLog, JsonConvert.SerializeObject(createDesktopLoginDTO));
            //        if (a.StatusCode == HttpStatusCode.OK)
            //        {
            //            var X = a.Content.ReadAsStringAsync()
            //                                                 .Result
            //                                                 //.Replace("\\", "")
            //                                                 //.Replace("\r\n", "'")
            //                                                 .Trim(new char[1] { '"' });
            //            var json = JsonConvert.DeserializeObject<
            //            DesktopLogin>(X);
            //            if (json != null)
            //            {
            //                dmsSessionLog[i].ServerSessionId = json.DesktopLoginId;
            //                dmsSessionLog[i].IsSynced = true;
            //                connection.Update(dmsSessionLog[i]);


            //            }

            //        }
            //    }
            //}

        }

        public async Task<bool> SyncLogDatan(DMSActivityLogVM dmsActivityLog)
        {
            //SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
            //ActivityLogDTO activityLogDTO = new ActivityLogDTO();
            //activityLogDTO.UserId = dmsActivityLog.UserId;
            //activityLogDTO.LogType = dmsActivityLog.LogType;
            //activityLogDTO.DesktopLoginId = dmsActivityLog.serversessionid;

            //activityLogDTO.LogDateTime = dmsActivityLog.LogDateTime;

            //activityLogDTO.ComputerName = dmsActivityLog.ComputerName;

            //activityLogDTO.ProcessOrUrl = dmsActivityLog.ProcessOrUrl;
            //activityLogDTO.AppOrWebPageName = dmsActivityLog.AppOrWebPageName;

            //activityLogDTO.SyncedOn = System.DateTime.Now;

            //activityLogDTO.CreatedBy = dmsActivityLog.UserId;

            //activityLogDTO.Action = dmsActivityLog.Action;

            //activityLogDTO.Source = dmsActivityLog.Source;

            //activityLogDTO.Folder = dmsActivityLog.Folder;



            //activityLogDTO.FileName = dmsActivityLog.FileName;

            //activityLogDTO.PrinterName = dmsActivityLog.PrinterName;

            //activityLogDTO.Todatetime = dmsActivityLog.Todatetime;
            //var ndmsActivityLog = connection.Query<DMSActivityLogVM>("SELECT * FROM DMSActivityLog WHERE DMSActivityLog.Id="+dmsActivityLog.ActId).FirstOrDefault();
            //if(ndmsActivityLog != null )
            //{
            //    if (ndmsActivityLog.IsDeleted == false)
            //    {
            //        var a = await HttpClientRq.PostRequest(ApiUrls.postActivityLog, JsonConvert.SerializeObject(activityLogDTO));

            //        if (a.StatusCode == HttpStatusCode.OK)
            //        {
            //            var X = a.Content.ReadAsStringAsync()
            //                                                 .Result
            //                                                 //.Replace("\\", "")
            //                                                 //.Replace("\r\n", "'")
            //                                                 .Trim(new char[1] { '"' });
            //            var json = JsonConvert.DeserializeObject<
            //            DMSActivityLogModel>(X);
            //            if (json != null)
            //            {
            //                DMSActivityLog dMSActivityLogMod = new DMSActivityLog();
            //                dMSActivityLogMod.Id = dmsActivityLog.Id;
            //                dMSActivityLogMod.IsDeleted = true;
            //                // connection.Update(dMSActivityLogMod);
            //                dMSActivityLogMod.ServerLogId = json.DMSActivityLogId;

            //                connection.Update(dMSActivityLogMod);
            //                UploadImage(dMSActivityLogMod);

            //            }
            //            else
            //            {
            //                DMSActivityLog dMSActivityLogMod = new DMSActivityLog();
            //                dMSActivityLogMod.Id = dmsActivityLog.Id;
            //                dMSActivityLogMod.IsDeleted = false;


            //                connection.Update(dMSActivityLogMod);

            //            }

            //        }
            //        else
            //        {
            //            DMSActivityLog dMSActivityLogMod = new DMSActivityLog();
            //            dMSActivityLogMod.Id = dmsActivityLog.Id;
            //            dMSActivityLogMod.IsDeleted = false;


            //            connection.Update(dMSActivityLogMod);

            //        }
            //    }
            //    else
            //    {
            //        DMSActivityLog dMSActivityLogMod = new DMSActivityLog();
            //        dMSActivityLogMod.Id = dmsActivityLog.Id;
            //        dMSActivityLogMod.IsDeleted = false;


            //        connection.Update(dMSActivityLogMod);

            //    }

            //}
            //else
            //{
            //    DMSActivityLog dMSActivityLogMod = new DMSActivityLog();
            //    dMSActivityLogMod.Id = dmsActivityLog.Id;
            //    dMSActivityLogMod.IsDeleted = false;
            //    connection.Update(dMSActivityLogMod);

            //}

            return true;
        }
        public async void SyncLogData()
        {
            //SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
            //var dmsActivityLog = connection.Query<DMSActivityLogVM>("SELECT *,serversessionid ,DMSActivityLog.Id as ActId FROM DMSActivityLog INNER  JOIN DmsSessionLog  ON DmsSessionLog.ID = DMSActivityLog.desktoploginid WHERE DmsSessionLog.issynced=1 AND DMSActivityLog.IsDeleted=0 ").ToList();
            //if (dmsActivityLog != null)
            //{


            //    for (int i = 0; i < dmsActivityLog.Count; i++)
            //    {
            //        DMSActivityLog dMSActivityLogMod = new DMSActivityLog();
            //        dMSActivityLogMod.Id = dmsActivityLog[i].Id;
            //        dMSActivityLogMod.IsDeleted = true;
            //        connection.Update(dMSActivityLogMod);
            //        var z=  await SyncLogDatan(dmsActivityLog[i]);


            //    }
            //}

        }
        public async void UploadImage(DMSActivityLog activityLog)
        {
            //SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
            //var dmsScLog = connection.Query<DMSScreenShotLog>("SELECT *  FROM DMSScreenShotLog WHERE DmsActivityLogId= "+activityLog.Id).ToList();
            //if (dmsScLog != null)
            //{
            //    for (int i = 0; i < dmsScLog.Count; i++)
            //    {
            //        string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            //        // Combine the base folder with your specific folder....
            //        string specificFolder = Path.Combine(folder, "DMSSnaps");
            //        var a = await HttpClientRq.UploadFilesAsync(ApiUrls.imageUpload, specificFolder + @"\" + dmsScLog[i].SnapShot, activityLog.ServerLogId.ToString(), (DateTime)dmsScLog[i].SnapshotDateTime, dmsScLog[i].LogType, activityLog.UserId.ToString());

            //        if (a.StatusCode == HttpStatusCode.OK)
            //        {
            //        }
            //    }
            //}

        }




    }
}
