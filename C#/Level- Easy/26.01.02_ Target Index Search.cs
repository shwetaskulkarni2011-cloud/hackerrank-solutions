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

// Problem: Target Index Search
// Difficulty: Easy
// Platform: HackerRank
// Link: https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/lookup-with-binary-search


class Result
{

    /*
     * Complete the 'binarySearch' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY nums
     *  2. INTEGER target
     */

    public static int binarySearch(List<int> nums, int target)
    {
        if(nums.Count()==0)
            return -1;
        
        int start = 0;
        int end = nums.Count()-1;
        int midIndex = end/2;
        if(end==1 && target == nums[0])
            return 0;
        while(midIndex<=end && midIndex>=start){
            if(target == nums[midIndex]){
                return midIndex;
            }
            else if(target > nums[midIndex]){
                start = midIndex + 1;
                midIndex = (end + start)/2;
            }
            else if(target < nums[midIndex]){
                end = midIndex-1;
                midIndex = (end + start)/2;
            }
        }
        return -1;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int numsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> nums = new List<int>();

        for (int i = 0; i < numsCount; i++)
        {
            int numsItem = Convert.ToInt32(Console.ReadLine().Trim());
            nums.Add(numsItem);
        }

        int target = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.binarySearch(nums, target);

        Console.WriteLine(result);
    }
}
