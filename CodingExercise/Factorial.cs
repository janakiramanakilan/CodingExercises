namespace CodingExercise;
using System;
using System.Linq.Expressions;
using System.Linq;
public class Factorial
{
    
public static int FactorialFor(int num) 
    {
        int factorial=1;
        for (int i=1;i<=num;i++)
            {
            factorial = factorial * i;
            } 
        return factorial;
    }
public static Func<int, int> FactorialRecursive = x => x < 0 ? -1 : x == 1 || x == 0 ? 1 : x * FactorialRecursive!(x - 1);
static Func<string, string> ReverseString = input => new string(input.Reverse().ToArray());
public static Func<string, bool> Palindrom = input => String.Equals(input, ReverseString(input));

}
