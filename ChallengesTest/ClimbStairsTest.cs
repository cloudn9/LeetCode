using Challenges.Easy;

using NUnit.Framework;


namespace Challenges.Test
{
    [TestFixture]
    public class ClimbStairsTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(2,
                ClimbStairs.Solution(2), "Error");
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual(3,
               ClimbStairs.Solution(3), "Error");
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual(5,
              ClimbStairs.Solution(4), "Error");
        }
    }
}
