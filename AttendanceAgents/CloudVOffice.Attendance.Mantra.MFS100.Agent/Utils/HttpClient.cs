using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ActMon.Utils
{
    public class HttpClientRq
    {
        public static async Task<HttpResponseMessage> GetCall(string url)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                string apiUrl = url;
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.Timeout = TimeSpan.FromSeconds(900);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.GetAsync(apiUrl);

                    return response;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async Task<HttpResponseMessage> PostRequest(string URI, string parameterValues, bool IsAnonymous = false)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.Timeout = TimeSpan.FromMinutes(20);
                if (IsAnonymous == false)
                {

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", CloudVOffice.Attendance.Mantra.MFS100.Agent.Properties.Settings.Default.Token);
                }
                HttpContent c = new StringContent(parameterValues, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(URI, c);
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    if (IsAnonymous == false)
                    {


                        string str = await GetNewJWT(CloudVOffice.Attendance.Mantra.MFS100.Agent.Properties.Settings.Default.Token, CloudVOffice.Attendance.Mantra.MFS100.Agent.Properties.Settings.Default.RefreshToken);
                        if (str == "Success")
                        {
                            response = await PostRequestRetry(URI, parameterValues, IsAnonymous);
                        }
                    }

                }
                return response;
            }
        }

        public static async Task<HttpResponseMessage> PostRequestRetry(string URI, string parameterValues, bool IsAnonymous = false)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.Timeout = TimeSpan.FromMinutes(20);
                if (IsAnonymous == false)
                {

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", CloudVOffice.Attendance.Mantra.MFS100.Agent.Properties.Settings.Default.Token);
                }
                HttpContent c = new StringContent(parameterValues, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(URI, c);

                return response;
            }
        }


        public static async Task<HttpResponseMessage> UploadFilesAsync(string URI, string path, string sessionId, string ActivityId, DateTime snapshotdatetime, string logType, bool IsAnonymous = false)
        {
            HttpClient client = new HttpClient();

            var multiForm = new MultipartFormDataContent();


            // add file and directly upload it
            FileStream fs = File.OpenRead(path);
            var streamContent = new StreamContent(fs);

            //string dd = MimeType(path);
            var fileContent = new ByteArrayContent(await streamContent.ReadAsByteArrayAsync());
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
            if (IsAnonymous == false)
            {

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", CloudVOffice.Attendance.Mantra.MFS100.Agent.Properties.Settings.Default.Token);
            }
            multiForm.Add(fileContent, "imageUpload", Path.GetFileName(path));

            multiForm.Add(new StringContent(logType), "LogType");
            multiForm.Add(new StringContent(ActivityId), "DesktopActivityLogId");
            multiForm.Add(new StringContent(sessionId), "DesktopLoginId");


            multiForm.Add(new StringContent(sessionId), "DesktopLoginId");
            multiForm.Add(new StringContent(sessionId), "CreatedBy");
            multiForm.Add(new StringContent(snapshotdatetime.ToString("ddMMMMyyyy HH:mm:ss")), "SnapshotDateTime");


            using (var response = await client.PostAsync(URI, multiForm))
            {
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    if (IsAnonymous == false)
                    {



                        string str = await GetNewJWT(CloudVOffice.Attendance.Mantra.MFS100.Agent.Properties.Settings.Default.Token, CloudVOffice.Attendance.Mantra.MFS100.Agent.Properties.Settings.Default.RefreshToken);

                        if (str == "Success")
                        {
                            var nresponse = await UploadFilesAsyncRetry(URI, path, sessionId, ActivityId, snapshotdatetime, logType, IsAnonymous);
                        }
                    }
                }
                return response;


            }
        }


        public static async Task<HttpResponseMessage> UploadFilesAsyncRetry(string URI, string path, string sessionId, string ActivityId, DateTime snapshotdatetime, string logType, bool IsAnonymous = false)
        {
            HttpClient client = new HttpClient();

            var multiForm = new MultipartFormDataContent();


            // add file and directly upload it
            FileStream fs = File.OpenRead(path);
            var streamContent = new StreamContent(fs);

            //string dd = MimeType(path);
            var fileContent = new ByteArrayContent(await streamContent.ReadAsByteArrayAsync());
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
            if (IsAnonymous == false)
            {

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", CloudVOffice.Attendance.Mantra.MFS100.Agent.Properties.Settings.Default.Token);
            }
            multiForm.Add(fileContent, "imageUpload", Path.GetFileName(path));

            multiForm.Add(new StringContent(logType), "LogType");
            multiForm.Add(new StringContent(ActivityId), "DesktopActivityLogId");
            multiForm.Add(new StringContent(sessionId), "DesktopLoginId");


            multiForm.Add(new StringContent(sessionId), "DesktopLoginId");
            multiForm.Add(new StringContent(sessionId), "CreatedBy");
            multiForm.Add(new StringContent(snapshotdatetime.ToString("ddMMMMyyyy HH:mm:ss")), "SnapshotDateTime");

            using (var response = await client.PostAsync(URI, multiForm))
            {
                return response;


            }
        }
        private static async Task<string> GetNewJWT(string JWT, string refreshToken)
        {

            TokenModel tokenModel = new TokenModel
            {
                RefreshToken = refreshToken,
                AccessToken = JWT,
                ClientId = System.Environment.GetEnvironmentVariable("COMPUTERNAME"),
                ClientName = (string)Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion").GetValue("ProductName")


            };

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiUrls.postRefreshToken);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.Timeout = TimeSpan.FromMinutes(20);

                HttpContent c = new StringContent(JsonConvert.SerializeObject(tokenModel), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(ApiUrls.postRefreshToken, c);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var X = response.Content.ReadAsStringAsync()
                                                            .Result
                                                            //.Replace("\\", "")
                                                            //.Replace("\r\n", "'")
                                                            .Trim(new char[1] { '"' });
                    var json = JsonConvert.DeserializeObject<NewRefreshToken>(X);

                    CloudVOffice.Attendance.Mantra.MFS100.Agent.Properties.Settings.Default.RefreshToken = json.RefreshToken;

                    CloudVOffice.Attendance.Mantra.MFS100.Agent.Properties.Settings.Default.Token = json.AccessToken.ToString();



                    return "Success";
                }
                else
                {
                    return "Failed";
                }

            }

        }
    }

    public class TokenModel
    {

        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string ClientName { get; set; }
        public string ClientId { get; set; }
    }
    public class NewRefreshToken
    {
        public string RefreshToken { get; set; }
        public string AccessToken { get; set; }
    }
    public class ApiUrls
    {
        public string _gateWayBaseUrl { get; set; } = "";
        public string _clientBaseUrl { get; set; } = "";
        public ApiUrls()
        {

            if (CloudVOffice.Attendance.Mantra.MFS100.Agent.Properties.Settings.Default.ApplicationUrl != null)
            {
                _gateWayBaseUrl = CloudVOffice.Attendance.Mantra.MFS100.Agent.Properties.Settings.Default.ApplicationUrl;
                _clientBaseUrl = CloudVOffice.Attendance.Mantra.MFS100.Agent.Properties.Settings.Default.ApplicationUrl;
            }
        }

        public static string getGatewayUrl()
        {

            return CloudVOffice.Attendance.Mantra.MFS100.Agent.Properties.Settings.Default.ApplicationUrl;




        }

        public static string getClientUrl()
        {
            return CloudVOffice.Attendance.Mantra.MFS100.Agent.Properties.Settings.Default.ApplicationUrl;




        }

        public static string postLogin = getGatewayUrl() + "/api/Login/Auth";
        public static string postRefreshToken = getGatewayUrl() + "/api/Login/RefreshToken";







    }
}
