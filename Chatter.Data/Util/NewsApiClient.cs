using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Chatter.Data.Util
{
    class NewsApiClient
    {
        public static HttpClient GetClient()
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.BaseAddress = new Uri("https://newsapi.org");

            return client;
        }
    }
}
