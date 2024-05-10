using NUnit.Framework;

namespace LeetCode75.Test
{
    [TestFixture]
    public class MoveZeroesTest
    {
        [Test]
        public void Test1()
        {
            Assert.That(MoveZeroes.Solution([0, 1, 0, 3, 12]),
                Is.EqualTo(new int[] { 1, 3, 12, 0, 0 }), "Error", null);

        }

        [Test]
        public void Test2()
        {
            Assert.That(MoveZeroes.Solution([0]),
                Is.EqualTo(new int[] { 0 }), "Error", null);
        }

        //[Test]
        //public void Test3()
        //{
        //    Assert.That(MoveZeroes.Solution([0, 0]),
        //        Is.EqualTo(new int[] { 0, 0 }), "Error", null);
        //}
    }
}
