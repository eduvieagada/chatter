using Chatter.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatter.Logic
{
    public interface INewsContainer
    {
       List<INewsItem> GetLatestNews();
    }
}
