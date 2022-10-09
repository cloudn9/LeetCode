using Challenges.Easy;

using NUnit.Framework;


namespace Challenges.Test
{
    [TestFixture]
    public class PalindromTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(true,
                Palindrom.Solution(121), "Error");
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual(false,
                Palindrom.Solution(-121), "Error"); 
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual(false,
                Palindrom.Solution(10), "Error");
        }


      

    }
}
