using CIFramework472;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var greetee = "Name";
            var announcer = new HelloWorldAnnouncer(greetee);
            var greeting = announcer.Greet();
            
            Assert.True(greeting.Contains(greetee));
        }
    }
}