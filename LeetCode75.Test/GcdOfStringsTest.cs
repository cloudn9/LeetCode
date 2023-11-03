using NUnit.Framework;

using LeetCode75;

namespace TIQ.Test
{
    [TestFixture]
    public class GcdOfStringsTest
    {
        [Test]
        public void Test1()
        {
            Assert.That(GcdOfStrings.Solution("ABCABC", "ABC"), Is.EqualTo("ABC"), "Error", null);
            Assert.That(GcdOfStrings.Solution1("ABCABC", "ABC"), Is.EqualTo("ABC"), "Error", null);
        }

        [Test]
        public void Test2()
        {
            Assert.That(GcdOfStrings.Solution("ABABAB", "ABAB"), Is.EqualTo("AB"), "Error", null);
            Assert.That(GcdOfStrings.Solution1("ABABAB", "ABAB"), Is.EqualTo("AB"), "Error", null);
        }


        [Test]
        public void Test3()
        {
            Assert.That(GcdOfStrings.Solution("LEET", "CODE"), Is.EqualTo(""), "Error", null);
            Assert.That(GcdOfStrings.Solution1("LEET", "CODE"), Is.EqualTo(""), "Error", null);
        }

        [Test]
        public void Test4()
        {
            Assert.That(GcdOfStrings.Solution("TAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX"), 
                Is.EqualTo("TAUXX"), "Error", null);
            Assert.That(GcdOfStrings.Solution1("TAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX"), 
                Is.EqualTo("TAUXX"), "Error", null);
        }
    }
}