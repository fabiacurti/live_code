using System;

Console.WriteLine("Valid Parentheses Test:\n");

string[] tests = { "()", "()[]{}", "(]", "{[]}", "([)]", "" };

foreach (string test in tests)
{
    Console.WriteLine($"{test} => {ValidParentheses.IsValid(test)}");
}
