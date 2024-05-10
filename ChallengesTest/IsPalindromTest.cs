using Challenges.Easy;

using NUnit.Framework;


namespace Challenges.Test
{
    [TestFixture]
    public class IsPalindromTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(true,
                IsPalindrom.Solution("A man, a plan, a canal: Panama"), "Error");
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual(false,
                IsPalindrom.Solution("race a car"), "Error"); 
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual(true,
                IsPalindrom.Solution(" "), "Error");
        }


      

    }
}
