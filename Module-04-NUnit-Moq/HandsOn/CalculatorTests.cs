using NUnit.Framework;
namespace NUnitHandsOn
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }
        [Test]
        public void TestAddition()
        {
            int result = calculator.Add(10, 20);
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void TestSubtraction()
        {
            int result = calculator.Subtract(20, 10);
            Assert.That(result, Is.EqualTo(10));
        }
    }
}
