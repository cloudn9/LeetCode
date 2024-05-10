using Challenges.EasyString;
using NUnit.Framework;


namespace Challenges.Test
{
    [TestFixture]
    public class LengthOfLastWordTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(5,
                LengthOfLastWord.Solution("Hello World"), "Error");
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual(4,
                LengthOfLastWord.Solution("   fly me   to   the moon  "), "Error");
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual(6,
                LengthOfLastWord.Solution("luffy is still joyboy"), "Error");
        }




    }
}
