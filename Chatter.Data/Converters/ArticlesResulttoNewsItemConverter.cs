using Chatter.Data.Models;
using Chatter.Logic.Models;
using NewsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatter.Data.Converters
{
    class ArticlesResulttoNewsItemConverter
    {
        public static INewsItem Convert(Article article)
        {
            return new NewsItem
            {
                Author = article.Author,
                SourceName = article.Source.Name,
                DatePublished = article.PublishedAt,
                Description = article.Description,
                ImageUrl = article.UrlToImage,
                Url = article.Url,
                Title = article.Title
            };
        }
    }
}
