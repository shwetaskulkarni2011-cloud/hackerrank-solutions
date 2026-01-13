
// Problem: 1975 maximum-matrix-sum
// Difficulty: Medium
// Platform: HackerRank
// Link: https://leetcode.com/problems/maximum-matrix-sum/description/?envType=daily-question&envId=2026-01-05

//All 98 test cases passed

public class Solution {
    public long MaxMatrixSum(int[][] matrix) {

        long sum = 0;
        int lowestNumber = int.MaxValue;
        int countOfN = 0;

        for(int i=0; i<matrix.Length ; i++){
            for(int j=0; j<matrix[i].Length; j++){
                sum += Math.Abs(matrix[i][j]);
                
                if(matrix[i][j]<0){
                    countOfN++;
                }
                lowestNumber = Math.Min(Math.Abs(matrix[i][j]),lowestNumber);
            }
        }
        if(countOfN%2 != 0){
            sum -= 2*lowestNumber;     //Here we subtracted twice bec initially we have added at line no 10
        }
        return sum;



        //--=====
        /*int[] oneD = matrix.SelectMany(x=> x).ToArray();
        Array.Sort(oneD);

        int sum = 0;
        int nValIndex = -1;
        for(int i=oneD.Count()-1 ; i>=0 ; i--){
            if(oneD[i]>0){
                sum = sum + oneD[i];
            }
            else{
                nValIndex = i;
                break;
            }
        }
        if(nValIndex %2 == 1 && nValIndex >0){
            for(int i=nValIndex ; i>=0 ; i--){
                sum = sum + (-1 * oneD[i]);
            }
        }
        else if ( nValIndex >0){
            for(int i=nValIndex-1 ; i>=0 ; i--){
                sum = sum + (-1 * oneD[i]);
            }
            sum = sum + oneD[nValIndex];
        }
        else if(nValIndex==0){
            sum = sum + oneD[0];;
        }
        return sum;*/
    }
}