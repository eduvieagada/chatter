using Chatter.Data.Converters;
using Chatter.Data.Manual.Models;
using Chatter.Data.Util;
using Chatter.Logic;
using Chatter.Logic.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Chatter.Data
{
    public class NewsContainer : INewsContainer
    {
        private readonly string apiKey;
        public NewsContainer(string apiKey)
        {
            this.apiKey = apiKey;
        }
        public List<INewsItem> GetLatestNews()
        {
            var client = NewsApiClient.GetClient();

            var response = client.GetAsync("/v2/top-headlines?sources=techcrunch&apiKey=1ed506b2d88f4400a191fd29778cbbce").Result;

            var result = response.Content.ReadAsAsync<ArticleList>().Result;

            return result.articles.Select(a => ArticlesResulttoNewsItemConverter.Convert(a)).ToList();
        }
    }
}
