using NUnit.Framework;
using Chatter.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Chatter.Logic.Models;

namespace Chatter.Tests.LogicTests
{
    [TestFixture]
    class ChatterLogicTests
    {
        private INewsContainer newsContainer;
        [SetUp]
        public void Initialize()
        {
            var newsContainerMock = new Mock<INewsContainer>();
            var mockNewsItem = new Mock<INewsItem>();
            newsContainerMock.Setup(n => n.GetLatestNews()).Returns(new List<INewsItem>
            {
                mockNewsItem.Object
            });

            newsContainer = newsContainerMock.Object;
        }

        [Test]
        public void NewsContainer_Should_Get_Latest_News()
        {
            var latestNews = newsContainer.GetLatestNews();

            Assert.IsNotEmpty(latestNews);
        }
    }
}
