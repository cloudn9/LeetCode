using NUnit.Framework;

namespace LeetCode75.Test
{
    [TestFixture]
    public class ProductExceptSelfTest
    {
        [Test]
        public void Test1()
        {
            Assert.That(ProductExceptSelf.Solution2([1, 2, 3, 4]),
                Is.EqualTo(new int[] { 24, 12, 8, 6 }), "Error", null);

        }

        [Test]
        public void Test2()
        {
            Assert.That(ProductExceptSelf.Solution([-1, 1, 0, -3, 3]),
                Is.EqualTo(new int[] { 0, 0, 9, 0, 0 }), "Error", null);
        }

        [Test]
        public void Test3()
        {
            Assert.That(ProductExceptSelf.Solution([0, 0]),
                Is.EqualTo(new int[] { 0, 0 }), "Error", null);
        }

        [Test]
        public void Test4()
        {
            Assert.That(ProductExceptSelf.Solution([1, 1]),
                Is.EqualTo(new int[] { 1, 1 }), "Error", null);
        }

        [Test]
        public void Test5()
        {
            Assert.That(ProductExceptSelf.Solution([0, 4, 0]),
                Is.EqualTo(new int[] { 0, 0, 0 }), "Error", null);
        }        
    }
}
