namespace DSALibrary.Educative.SlidingWindow
{
    // Given an array of positive numbers and a positive number ‘k’, find the maximum sum of any contiguous subarray of size ‘k’.

    // Input: [2, 1, 5, 1, 3, 2], k=3 
    // Output: 9
    // Explanation: Subarray with maximum sum is [5, 1, 3].

    // Input: [2, 3, 4, 1, 5], k=2 
    // Output: 7
    // Explanation: Subarray with maximum sum is [3, 4].
    public class MaxSumSubArrayOfSizeK
    {
        //​ O(N) time | O(1) space
        public int FindMaxSumSubArray(int[] arrItems, int k)
        {
            //  Time Complexity #
            //  The time complexity of the above algorithm will be O(N).

            //  Space Complexity #
            //  The algorithm runs in constant space O(1).

            var windowStart = 0;
            var windowSum = 0;
            var maxSum = int.MinValue;

            for (int windowEnd = 0; windowEnd < arrItems.Length; windowEnd++)
            {
                windowSum += arrItems[windowEnd];
                maxSum = Math.Max(windowSum, maxSum);
                if (windowEnd >= k - 1)
                {
                    windowSum -= arrItems[windowStart];
                    windowStart++;
                }
            }
            return maxSum;
        }
    }
}
