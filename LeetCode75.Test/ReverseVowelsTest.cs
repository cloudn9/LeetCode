using NUnit.Framework;

namespace LeetCode75.Test
{
    [TestFixture]
    public class ReverseVowelsTest
    {
        [Test]
        public void Test1()
        {
            Assert.That(ReverseVowels.Solution("hello"), Is.EqualTo("holle"), "Error", null);
            Assert.That(ReverseVowels.Solution1("hello"), Is.EqualTo("holle"), "Error", null);
        }

        [Test]
        public void Test2()
        {
            Assert.That(ReverseVowels.Solution("leetcode"), Is.EqualTo("leotcede"), "Error", null);
            Assert.That(ReverseVowels.Solution1("leetcode"), Is.EqualTo("leotcede"), "Error", null);
        }
    }
}
