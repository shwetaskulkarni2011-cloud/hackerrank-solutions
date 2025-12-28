#region using statement
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
# end region

// Problem: Check Palindrome by Filtering Non-Letters
// Difficulty: Easy
// Platform: HackerRank
// Link: https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/check-palindrome-filter-non-letters/problem

class Result
{

    /*
     * Complete the 'isAlphabeticPalindrome' function below.
     *
     * The function is expected to return a BOOLEAN.
     * The function accepts STRING code as parameter.
     */

    public static bool isAlphabeticPalindrome(string code)
    {
        string pattern = "[^a-zA-Z]";
        Regex r = new Regex(pattern);
        string result = Regex.Replace(code,pattern,"");
        
        string reversedStr = new String(result.ToLower().Reverse().ToArray());
        return String.Equals(result.ToLower(), reversedStr);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string code = Console.ReadLine();

        bool result = Result.isAlphabeticPalindrome(code);

        Console.WriteLine((result ? 1 : 0));
    }
}
