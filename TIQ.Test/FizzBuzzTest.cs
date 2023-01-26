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
      var output = new List<string> { "1", "2", "Fizz" };
      Assert.That(FizzBuzz.Solution(3), Is.EqualTo(output), "Error", null);
    }

    [Test]
    public void Test2()
    {
      var output = new List<string> { "1", "2", "Fizz", "4", "Buzz" };
      Assert.That(FizzBuzz.Solution(5), Is.EqualTo(output), "Error", null);
    }

    [Test]
    public void Test3()
    {
      var output = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
      Assert.That(FizzBuzz.Solution(15), Is.EqualTo(output), "Error", null);
    }
  }
}