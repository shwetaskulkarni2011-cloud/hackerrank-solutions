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

// Problem: Day of Programmer
// Difficulty: Easy
// Platform: HackerRank
// Link: https://www.hackerrank.com/challenges/day-of-the-programmer/problem

class Result
{

    /*
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
        bool isJulian = year<1918;
        string result="";
        if(year==1918){
            return "26.09.1918";
            //1918 is non leap year according to both calender i.e. 28 days
            //leap year + 13 days = 26
        }
        else if(isJulian && year%4==0){
            result = "12.09."+year;
            //leap year has 29 days
            //Non leap year has 28 days
        }
        else if(year%400==0 || (year%4==0 && year%100!=0)){
            result = "12.09."+year;
        }
        else{
            result = "13.09."+year;
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
