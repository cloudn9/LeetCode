using NUnit.Framework;


namespace DS1.Test
{
    [TestFixture]
    public class BestTimeToBuyAndSellStockTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(5,
                BestTimeToBuyAndSellStock.Solution(new int[] { 7, 1, 5, 3, 6, 4 }), "Error");
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual(0,
               BestTimeToBuyAndSellStock.Solution(new int[] { 7, 6, 4, 3, 1 }), "Error");
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual(2,
               BestTimeToBuyAndSellStock.Solution(new int[] { 2, 4, 1 }), "Error");
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual(3,
               BestTimeToBuyAndSellStock.Solution(new int[] { 2, 1, 4 }), "Error");
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual(4,
               BestTimeToBuyAndSellStock.Solution(new int[] { 3, 3, 5, 0, 0, 3, 1, 4 }), "Error");
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual(3,
               BestTimeToBuyAndSellStock.Solution(new int[] { 1, 2, 4 }), "Error");
        }


        [Test]
        public static void Test7()
        {
            Assert.AreEqual(2,
               BestTimeToBuyAndSellStock.Solution(new int[] { 2, 1, 2, 1, 0, 1, 2 }), "Error");
        }

        [Test]
        public static void Test8()
        {
            Assert.AreEqual(4,
               BestTimeToBuyAndSellStock.Solution(new int[] { 3, 2, 6, 5, 0, 3 }), "Error");
        }
    }
}
