using Chatter.Data.Converters;
using Chatter.Logic;
using Chatter.Logic.Models;
using NewsAPI;
using NewsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatter.Data
{
    public class NewsContainer : INewsContainer
    {
        private readonly string apiKey;
        public NewsContainer(string apiKey)
        {
            this.apiKey = apiKey;
        }
        public IEnumerable<INewsItem> GetLatestNews()
        {
            var newsApiClient = new NewsApiClient(apiKey);

            var topHeadlinesRequest = new TopHeadlinesRequest();

            ArticlesResult result = newsApiClient.GetTopHeadlines(topHeadlinesRequest);

            foreach (Article article in result.Articles)
            {
                yield return ArticlesResulttoNewsItemConverter.Convert(article);
            }

        }
    }
}
