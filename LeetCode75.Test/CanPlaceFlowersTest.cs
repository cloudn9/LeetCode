using NUnit.Framework;

namespace LeetCode75.Test
{
    [TestFixture]
    public class CanPlaceFlowersTest
    {
        [Test]
        public void Test1()
        {
            Assert.That(CanPlaceFlowers.Solution(new int[] { 1, 0, 0, 0, 1 }, 1),
                Is.EqualTo(true), "Error", null);
        }

        [Test]
        public void Test2()
        {
            Assert.That(CanPlaceFlowers.Solution(new int[] { 1, 0, 0, 0, 1 }, 2),
               Is.EqualTo(false), "Error", null);
        }


        [Test]
        public void Test3()
        {
            Assert.That(CanPlaceFlowers.Solution(new int[] { 1, 0, 0, 0, 0, 0, 1 }, 2),
                Is.EqualTo(true), "Error", null);
        }

        [Test]
        public void Test4()
        {
            Assert.That(CanPlaceFlowers.Solution(new int[] { 1, 0, 1, 0, 1, 0, 1 }, 1),
                Is.EqualTo(false), "Error", null);
        }
    }
}