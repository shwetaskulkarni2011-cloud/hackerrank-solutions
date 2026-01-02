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
#end region

// Problem: Count Elements Greater Than Previous Average
// Difficulty: Easy
// Platform: HackerRank
// Link: https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/count-elements-greater-than-previous-average

class Result
{

    /*
     * Complete the 'countResponseTimeRegressions' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY responseTimes as parameter.
     */

    public static int countResponseTimeRegressions(List<int> responseTimes)
    {
        int count =0;
        if(responseTimes.Count>0){
            for(int i=1; i< responseTimes.Count; i++){
                IEnumerable<int> previousElements = responseTimes.Take(i);
                double average = previousElements. Average();
                if(Convert.ToDouble(responseTimes[i]).CompareTo(average)>0){
                    count++;
                }
                //Some test cases are failing for below condition
                //if(responseTimes[i].CompareTo(average)>0)
                //Because responseTime[i] is int type and we are comparing it with average which is of double type
                //Hence some testcases not working and giving argument exception I believe
                
                // if(average<(responseTimes[i])){
                //     count++;
                // }
                //Above code will also work, here int will be converted to double and then comparison happens
            }
        }
        
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int responseTimesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> responseTimes = new List<int>();

        for (int i = 0; i < responseTimesCount; i++)
        {
            int responseTimesItem = Convert.ToInt32(Console.ReadLine().Trim());
            responseTimes.Add(responseTimesItem);
        }

        int result = Result.countResponseTimeRegressions(responseTimes);

        Console.WriteLine(result);
    }
}
