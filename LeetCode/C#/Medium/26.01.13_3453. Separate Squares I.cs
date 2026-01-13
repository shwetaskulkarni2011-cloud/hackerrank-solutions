// Problem: 3453. Separate Squares I
// Difficulty: Medium
// Platform: LeetCode
// Link: https://leetcode.com/problems/separate-squares-i/description/?envType=daily-question&envId=2026-01-13




public class Solution {
    public double SeparateSquares(int[][] squares) {
        double low = int.MaxValue;
        double high = int.MinValue;
        double total = 0.0000;

        for(int i=0; i<squares.Length; i++){
            double x = squares[i][0];
            double y = squares[i][1];
            double l = squares[i][2];

            total +=l*l;
            low = Math.Min(low,y);
            high = Math.Max(high, y+l);

        }
        double result_y = 0.0000;
        while(high-low>1e-5){
            double mid_y = low + (high-low)/2;
            result_y = mid_y;

            if(check(squares,mid_y,total)==true){
                high = mid_y;
            }
            else{
                low=mid_y;
            }
        }
        return result_y;
    }
    public bool check(int[][] squares,double mid_y, double total){
        double bot_area =0;
        for(int i=0; i<squares.Length; i++){
            double y = squares[i][1];
            double l = squares[i][2];

            double boty =y;
            double topy = y+l;

            if(mid_y >= topy){
                bot_area += l*l;
            }
            else if(mid_y >boty){
                bot_area += (mid_y-boty)*l;
            }
        }
        return bot_area >=total/2.0;
    }
}