using NUnit.Framework;

namespace LeetCode75.Test
{
    [TestFixture]
    public class ReverseWordsTest
    {
        [Test]
        public void Test1()
        {
            Assert.That(ReverseWords.Solution("the sky is blue"), Is.EqualTo("blue is sky the"), "Error", null);
            Assert.That(ReverseWords.Solution("  hello world  "), Is.EqualTo("world hello"), "Error", null);
        }

        [Test]
        public void Test2()
        {
            Assert.That(ReverseWords.Solution("a good   example"), Is.EqualTo("example good a"), "Error", null);
            // Assert.That(ReverseWords.Solution1("leetcode"), Is.EqualTo("leotcede"), "Error", null);
        }
    }
}
