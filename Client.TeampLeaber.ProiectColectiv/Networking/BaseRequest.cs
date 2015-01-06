using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Networking
{
    public class BaseRequest : HttpClient
    {
        protected HttpResponseMessage response;
        public BaseRequest()
        {
            this.DefaultRequestHeaders.Accept.Clear();
            this.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            this.BaseAddress = new Uri(Utils.Constants.HOST);
        }
 
    }
}
