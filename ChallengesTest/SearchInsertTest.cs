using Challenges.Easy;

using NUnit.Framework;


namespace Challenges.Test
{
    [TestFixture]
    public class SearchInsertTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(2,
                SearchInsert.Solution(new[] { 1, 3, 5, 6 }, 5), "Error");
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual(1,
               SearchInsert.Solution(new[] { 1, 3, 5, 6 }, 2), "Error");
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual(4,
              SearchInsert.Solution(new[] { 1, 3, 5, 6 }, 7), "Error");
        }




    }
}
