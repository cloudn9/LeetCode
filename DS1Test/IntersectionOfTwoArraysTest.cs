using NUnit.Framework;


namespace DS1.Test
{
    [TestFixture]
    public class IntersectionOfTwoArraysTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(new int[] { 2, 2 },
                IntersectionOfTwoArrays.Solution(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }), "Error");
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual(new int[] { 1 },
               IntersectionOfTwoArrays.Solution(new int[] { 3, 1, 2 }, new int[] { 1, 1 }), "Error");
        }


        [Test]
        public static void Test3()
        {
            Assert.AreEqual(new int[] { 4, 9 },
               IntersectionOfTwoArrays.Solution(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }), "Error");
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual(new int[] { 2 },
                IntersectionOfTwoArrays.Solution(new int[] { 1, 2, 2, 1 }, new int[] { 2 }), "Error");
        }
    }
}
