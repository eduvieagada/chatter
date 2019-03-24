using Chatter.App_Start;
using Chatter.Logic;
using System;
using System.Linq;
using System.Web.Http;

namespace Chatter.Controllers
{
    public class NewsController : ApiController
    {
        private readonly INewsContainer newsContainer;
        private readonly ILoggging logger;
        public NewsController(INewsContainer container, ILoggging logger)
        {
            newsContainer = container;
            this.logger = logger;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var news = newsContainer.GetLatestNews().ToList();

                return Ok(news);
            }
            catch (Exception ex)
            {
                logger.Error(ex);

                return BadRequest();
            }
        }
    }
}
