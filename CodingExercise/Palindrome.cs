using System;
using System.Linq.Expressions;
using System.Linq;

namespace CodingExercise;
public class Palindrome
{
    public static Func<string, bool> Palindrom = input => String.Equals(input, ReverseString!(input));
    static Func<string, string> ReverseString = input => new string(input.Reverse().ToArray());
    
}