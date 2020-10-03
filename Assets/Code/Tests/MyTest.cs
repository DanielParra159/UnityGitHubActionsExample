using NUnit.Framework;

namespace Tests
{
    public class MyTest
    {
        [Test]
        public void MyTestSimplePasses()
        {
            Assert.AreEqual(2 + 2, 4);
        }
    }
}
