using NUnit.Framework;

namespace Tests
{
    public class Example
    {
        [Test]
        public void ExampleSimplePasses()
        {
            Assert.Pass("This test Passes");
        }

        [Test]
        public void ExampleSimpleFails()
        {
            Assert.Fail("This test should fail");
        }

        [Test]
        public void ExampleConditionalPass()
        {
            const int a = 100;
            Assert.Greater(a, 99);
        }

        [Test]
        public void ExampleTestScript()
        {
            int expected = 48;
            int result = UnitTestBehaviour.SimpleCalc(5);
            Assert.AreEqual(expected, result);
        }
    }
}
