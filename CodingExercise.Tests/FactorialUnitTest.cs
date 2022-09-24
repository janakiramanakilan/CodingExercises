using NUnit.Framework;
using CodingExercise;
namespace codingExercise.Tests;

public class FactorialUnitTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestPositiveValue()
    {
        var result = Factorial.FactorialRecursive(5);
        Assert.AreEqual(result,120,"The Result should be 120");
        
    }
    [Test]
    public void TestNegativeValue()
    {
        var result = Factorial.FactorialRecursive(-5);
        Assert.AreEqual(result,-1,"The Result should be -1");
        
    }
    
    [Test]
    [TestCase(0)]
    [TestCase(null)]
    [TestCase(-1)]
     [TestCase("1")]
    public void TestRandomValues(int x)
    {
        var result = Factorial.FactorialRecursive(x);
        Assert.AreNotEqual(result,0,"Failed test");

        
    }
    [Test]
    public void TestPalindromeValue()
    {
        bool result = Palindrome.Palindrom("madam");
        Assert.AreEqual(result,true,"This is Palindrome string");
        
    }
}