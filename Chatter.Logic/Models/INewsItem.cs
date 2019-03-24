using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatter.Logic.Models
{
    public interface INewsItem
    {
        string SourceName { get; set; }
        string Author { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        string Url { get; set; }
        string ImageUrl { get; set; }
        DateTime? DatePublished { get; set; }
    }
}
