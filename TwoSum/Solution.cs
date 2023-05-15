using System;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {

            int[] arr = new int[nums.Length];
            
            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] =  Array.IndexOf(nums,nums[i]);
            }
            
            return arr;
        }
    }
}