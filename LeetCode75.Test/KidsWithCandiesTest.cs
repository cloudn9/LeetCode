using NUnit.Framework;

namespace LeetCode75.Test.Test
{
    [TestFixture]
    public class KidsWithCandiesTest
    {
        [Test]
        public void Test1()
        {
            Assert.That(KidsWithCandies.Solution(new int[] { 4, 2, 1, 1, 2 }, 1),
                Is.EqualTo(new bool[] { true, false, false, false, false }), "Error", null);
        }

        [Test]
        public void Test2()
        {
            Assert.That(KidsWithCandies.Solution(new int[] { 12,1,12}, 10),
               Is.EqualTo(new bool[] { true, false, true }), "Error", null);
        }


        [Test]
        public void Test3()
        {
            Assert.That(KidsWithCandies.Solution(new int[] { 2, 3, 5, 1, 3 }, 3),
                Is.EqualTo(new bool[] { true, true, true, false, true }), "Error", null);
        }
    }
}