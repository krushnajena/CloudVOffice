using DesktopMonitoringSystem.Classes;
using Microsoft.Win32;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DesktopMonitoringSystem.Utils
{
    public class HttpClientRq
    {
        public static Task<HttpResponseMessage> GetCall(string url, bool IsAnonymous = false)
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
                    var response = client.GetAsync(apiUrl);
                    response.Wait();

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
                    SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
                    var a = connection.Query<User>("select * from User").FirstOrDefault();
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", a.Token);
                }
                //GET Method  
                HttpContent c = new StringContent(parameterValues, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(URI, c);
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
                    var a = connection.Query<User>("select * from User").FirstOrDefault();

                    string str = await GetNewJWT(a.Token, a.RefreshToken, a.Id);
                    if (str == "Success")
                    {
                        response = await PostRequestRetry(URI, parameterValues, IsAnonymous);
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
                    SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
                    var a = connection.Query<User>("select * from User").FirstOrDefault();
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", a.Token);
                }
                HttpContent c = new StringContent(parameterValues, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(URI, c);

                return response;
            }
        }


        private static async Task<string> GetNewJWT(string JWT, string refreshToken, int Id)
        {
            SQLiteConnection connection = new SQLiteConnection(DbContext.databasePath);
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

                    User dMSActivityLogMod = new User();
                    dMSActivityLogMod.Id = Id;
                    dMSActivityLogMod.RefreshToken = json.RefreshToken;

                    dMSActivityLogMod.Token = json.AccessToken.ToString();
                    connection.Update(dMSActivityLogMod);
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
}
