using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Infrastructure.Http
{
    public interface IHttpWebClients
    {
      
     
        string PostRequest(string URI, string parameterValues, bool isAnonymous =false);
        
        string GetRequest(string URI,  bool isAnonymous = false);
  
    }
}
