using Chatter.Data.Manual.Models;
using Chatter.Data.Models;
using Chatter.Logic.Models;

namespace Chatter.Data.Converters
{
    class ArticlesResulttoNewsItemConverter
    {
        public static INewsItem Convert(Article article)
        {
            return new NewsItem
            {
                Author = article.author,
                SourceName = article.source.name,
                DatePublished = article.publishedAt,
                Description = article.description,
                ImageUrl = article.urlToImage,
                Url = article.url,
                Title = article.title
            };
        }
    }
}
