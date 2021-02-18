using NUnit.Framework;

namespace ECSLegacy.Test.Unit
{
    public class Tests
    {
        private ECS UUT; 

        [SetUp]
        public void Setup()
        {
            UUT = new ECS(20);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}