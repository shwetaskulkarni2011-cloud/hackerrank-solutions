// Problem: 961. N-Repeated Element in Size 2N Array
// Difficulty: Easy
// Platform: LeetCode
// Link: https://leetcode.com/problems/n-repeated-element-in-size-2n-array


public class Solution {
    public int RepeatedNTimes(int[] nums) {
        Dictionary<int,int> uniqueElement = new Dictionary<int,int>();
        foreach(int num in nums){
            if(uniqueElement.ContainsKey(num)){
                return num;
            }
            else{
                uniqueElement.Add(num,1);
            }
        }
        return -1;
    }
}