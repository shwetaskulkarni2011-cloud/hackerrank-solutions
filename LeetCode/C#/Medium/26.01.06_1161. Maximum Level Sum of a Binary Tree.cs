/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
 
// Problem: 1161. Maximum Level Sum of a Binary Tree
// Difficulty: Medium
// Platform: LeetCode
// Link: https://leetcode.com/problems/maximum-level-sum-of-a-binary-tree/description/?envType=daily-question&envId=2026-01-06

//All 41 test cases passed

public class Solution {
    public int MaxLevelSum(TreeNode root) {
        int maxSum = int.MinValue;
        int resultLevel = 0;

        Queue<TreeNode> que = new Queue<TreeNode>();
        que.Enqueue(root);
        int currentLevel = 1;
        while(que.Any()){
            int n = que.Count();
            int sum = 0;
            while(n-->0){
                TreeNode temp = que.Peek();
                que.Dequeue();

                sum += temp.val;

                if(temp.left != null){
                    que.Enqueue(temp.left);
                }
                if(temp.right != null){
                    que.Enqueue(temp.right);
                }
            }
            if(sum > maxSum){
                maxSum = sum;
                resultLevel = currentLevel;
            }
            currentLevel++;
        }
        return resultLevel;
    }
}