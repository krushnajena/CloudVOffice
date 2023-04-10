

using System.Text;
using System.Net.Http.Headers;


namespace CloudVOffice.Core.Infrastructure.Http
{

    public class HttpWebClients : IHttpWebClients
    {
      
        public HttpWebClients(  )
        {
          
        }
      

        public string PostRequest(string Url, string parameterValues, bool isAnonymous)
        {
           
                string URL = Url;
                string jsonString = null;

                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri(URL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    client.Timeout = TimeSpan.FromMinutes(20);
                    //GET Method  
                    HttpContent c = new StringContent(parameterValues, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync(URL, c).Result;
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {

                        jsonString = response.Content.ReadAsStringAsync()
                                                       .Result
                                                       //.Replace("\\", "")
                                                       //.Replace("\r\n", "'")
                                                       .Trim(new char[1] { '"' });
                    }
                    


                }
                return jsonString;
           

        }


      
        public string GetRequest(string Url, bool isAnonymous= true)
        {
          
             

                string URL = Url;
                string jsonString = null;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(URL);
                    client.DefaultRequestHeaders.Accept.Clear();
                 // var jwt = GetJwt();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                  
                    //GET Method  
                    HttpResponseMessage response = client.GetAsync(URL).Result;
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        jsonString = response.Content.ReadAsStringAsync()
                                                       .Result
                                                       //.Replace("\\", "")
                                                       .Trim(new char[1] { '"' });

                    }
                   
                }
                return jsonString;
            
            
        }



    }
}
