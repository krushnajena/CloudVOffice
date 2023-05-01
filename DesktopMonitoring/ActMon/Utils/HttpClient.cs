using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;

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
        public static async Task<HttpResponseMessage> PostRequest(string URI, string parameterValues)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.Timeout = TimeSpan.FromMinutes(20);
                //GET Method  
                HttpContent c = new StringContent(parameterValues, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(URI, c);
               
                return response;
            }
        }

        public static async Task<HttpResponseMessage> UploadFilesAsync(string URI, string path, string ActivityId, DateTime snapshotdatetime,string logType,string createdby)
        {
            HttpClient client = new HttpClient();

            var multiForm = new MultipartFormDataContent();

           
                // add file and directly upload it
                FileStream fs = File.OpenRead(path);
                var streamContent = new StreamContent(fs);

                //string dd = MimeType(path);
                var fileContent = new ByteArrayContent(await streamContent.ReadAsByteArrayAsync());
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                multiForm.Add(fileContent, "file", Path.GetFileName(path));
          
            multiForm.Add(new StringContent(logType),"LogType");
            multiForm.Add(new StringContent(ActivityId), "DmsActivityLogId");
            multiForm.Add(new StringContent(snapshotdatetime.ToString("ddMMMMyyyy HH:mm:ss")), "SnapshotDateTime");
            multiForm.Add(new StringContent(createdby.ToString()), "CreatedBy");

            using (var response = await client.PostAsync(URI, multiForm))
            {
                return response;

               
            }
        }
    }
}
