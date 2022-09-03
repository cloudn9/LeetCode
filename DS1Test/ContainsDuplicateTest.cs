using DS1;

using NUnit.Framework;


namespace DS1.Test
{
    [TestFixture]
    public class ContainsDuplicateTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(true,
                ContainsDuplicate.Solution(new int[] { 1, 2, 3, 1 }));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual(false,
              ContainsDuplicate.Solution(new int[] { 1, 2, 3, 4 }));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual(true,
             ContainsDuplicate.Solution(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
        }
    }
}
