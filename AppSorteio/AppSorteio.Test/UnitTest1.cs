using AppSorteio.Business;
using AppSorteio.Model;
using NUnit.Framework;

namespace AppSorteio.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var prizeDrawPerson = new PrizeDraw().PrizeDrawPerson();
            Assert.IsNotNull(prizeDrawPerson);
        }
    }
}