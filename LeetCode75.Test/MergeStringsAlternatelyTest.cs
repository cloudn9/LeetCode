using NUnit.Framework;

using LeetCode75;

namespace TIQ.Test
{
    [TestFixture]
    public class MergeStringsAlternatelyTest
    {
        [Test]
        public void Test1()
        {
            Assert.That(MergeStringsAlternately.Solution("abc", "pqr"), Is.EqualTo("apbqcr"), "Error", null);
        }

        [Test]
        public void Test2()
        {
            Assert.That(MergeStringsAlternately.Solution("ab", "pqrs"), Is.EqualTo("apbqrs"), "Error", null);
        }


        [Test]
        public void Test3()
        {
            Assert.That(MergeStringsAlternately.Solution("abcd", "pq"), Is.EqualTo("apbqcd"), "Error", null);
        }
    }
}