// Problem: 1266. Minimum Time Visiting All Points 
// Difficulty: Easy
// Platform: LeetCode
// Link: https://leetcode.com/problems/minimum-time-visiting-all-points/?envType=daily-question&envId=2026-01-12

//All 123 test cases passed

public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        int ans = 0;
        for(int i=1; i<points.Length;i++){
            ans += Math.Max(Math.Abs(points[i][0]-points[i-1][0]),Math.Abs(points[i][1]-points[i-1][1]));
        }
        return ans;
    }
}