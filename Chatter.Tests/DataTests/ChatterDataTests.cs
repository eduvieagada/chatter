using Chatter.Data;
using Chatter.Logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatter.Tests.DataTests
{
    [TestFixture]
    class ChatterDataTests
    {
        private INewsContainer container;
        [SetUp]
        public void Initialize()
        {
            container = new NewsContainer("1ed506b2d88f4400a191fd29778cbbce");
        }
        [Test]
        public void NewsContainer_Should_Return_News()
        {
            Assert.IsNotEmpty(container.GetLatestNews().ToList());
        }
    }
}
