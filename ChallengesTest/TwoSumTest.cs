using Challenges.Easy;

using NUnit.Framework;


namespace Challenges.Test
{
    [TestFixture]
    public class TwoSumTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(new int[] { 0, 1 },
                TwoSum.Solution(new int[] { 2, 7, 11, 15 }, 9), "Error");
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual(new int[] { 1, 2 },
                TwoSum.Solution(new int[] { 3, 2, 4 }, 6), "Error");
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual(new int[] { 0, 1 },
                TwoSum.Solution(new int[] { 3, 3 }, 6), "Error");
        }


        [Test]
        public static void Test4()
        {
            Assert.AreEqual(new int[] { 0, 3 },
                TwoSum.Solution(new int[] { 0, 4, 3, 0 }, 0), "Error");
        }

      

    }
}
