using NUnit.Framework;


namespace DS1.Test
{
    [TestFixture]
    public class MergeSortedArrayTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(new int[] { 1, 2, 2, 3, 5, 6 },
                MergeSortedArray.Solution(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3), "Error");
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual(new int[] { 1 },
                MergeSortedArray.Solution(new int[] { 1 }, 1, new int[] { }, 0), "Error");
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual(new int[] { 1 },
                MergeSortedArray.Solution(new int[] { 0 }, 0, new int[] { 1 }, 1), "Error");
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual(new int[] { 1, 2, 2, 3, 5, 6 },
                MergeSortedArray.Solution(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3), "Error");
        }

    }
}
