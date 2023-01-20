using NUnit.Framework;

using TopInterviewQuestions;

namespace TIQ.Test
{
  [TestFixture]
  public class FizzBuzzTest
  {
    [Test]
    public void Test1()
    {
      string[] output = { "1", "2", "Fizz" };
      Assert.That(FizzBuzz.Solution(3), Is.EqualTo(output), "Error", null);
    }
  }
}