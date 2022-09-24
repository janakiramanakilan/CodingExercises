using NUnit.Framework;
using CodingExercise;
namespace codingExercise.Tests;

public class PalindromeUnitTest
{
    [SetUp]
    public void Setup()
    {
    }
  
    [Test]
    [TestCase("010")]
    [TestCase("111")]
    [TestCase("geeksskeeg")]
    [TestCase("1010101010101")]
    public void TestPalindromeValue(string x)
    {
        bool result = Palindrome.Palindrom(x);
        Assert.AreEqual(result,true,"This is Palindrome string");
        
    }
    [Test]
    [TestCase("0101")]
    [TestCase("11100")]
    [TestCase("madamm")]
    [TestCase("10")]
    public void TestNotPalindromeValue(string x)
    {
        bool result = Palindrome.Palindrom(x);
        Assert.AreNotEqual(result,true,"This is Palindrome string");
        
    }
    [Test]
    [TestCase("01")]
    [TestCase("null")]
    [TestCase("-1")]
    [TestCase("10")]
    public void TestRandomValues(string x)
    {
        bool result = Palindrome.Palindrom(x);
        Assert.AreNotEqual(result,true,"Failed test");
        
    }
    
    
}
