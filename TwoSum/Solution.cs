using System;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    int res = nums[i] + nums[j];

                    if ( res == target && i != j)
                    {
                        return new[] { i, j };
                    }
                }
            }

            return new[] {0};
        }
    }
}