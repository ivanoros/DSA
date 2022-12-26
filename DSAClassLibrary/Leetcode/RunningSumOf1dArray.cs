namespace DSAClassLibrary.Leetcode
{
    //  https://leetcode.com/problems/running-sum-of-1d-array/
    //  1480. Running Sum of 1d Array
    public class RunningSumOf1dArray
    {
        public int[] RunningSum(int[] nums)
        {
            var runningSum = new int[nums.Length];
            var previousSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                runningSum[i] = previousSum + nums[i];
                previousSum = runningSum[i];
            }

            return runningSum;
        }

        // Approach 1: Using Separate Space
        // Complexity Analysis
        // Time complexity: O(n) where nnn is the length of the input array.
        // This is because we use a single loop that iterates over the entire array to calculate the running sum.
        // Space complexity: O(1) since we don't use any additional space to find the running sum.
        // Note that we do not take into consideration the space occupied by the output array.
        public int[] RunningSumNew(int[] nums)
        {
            var runningSum = new int[nums.Length];
            runningSum[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                runningSum[i] = runningSum[i - 1] + nums[i];
            }

            return runningSum;
        }

        // Approach 2: Using Input Array for Output
        // Complexity Analysis
        // Time complexity: O(n) where nnn is the length of input array.
        // Space complexity: O(1) since we don't use any additional space to find the running sum.
        // Note that we do not take into consideration the space occupied by the output array.

        public int[] RunningSumUsingSameInputArray(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i - 1] + nums[i];
            }
            return nums;
        }
    }
}
