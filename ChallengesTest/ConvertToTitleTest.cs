using Challenges.Easy;

using NUnit.Framework;


namespace Challenges.Test
{
    [TestFixture]
    public class ConvertToTitleTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("A",
                ConvertToTitle.Solution(1), "Error");
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual("AB",
               ConvertToTitle.Solution(28), "Error");
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual("ZY",
              ConvertToTitle.Solution(701), "Error");
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual("FXSHRXW",
              ConvertToTitle.Solution(2147483647), "Error");
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual("Z",
              ConvertToTitle.Solution(26), "Error");
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual("AZ",
              ConvertToTitle.Solution(52), "Error");
        }
    }
}
