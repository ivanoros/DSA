namespace CodingPatternsLibrary.SlidingWindow
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
            //  If you observe closely, you will realize that to calculate the sum of a contiguous subarray
            //  we can utilize the sum of the previous subarray. For this, consider each subarray as a Sliding Window of size ‘k’.
            //  To calculate the sum of the next subarray, we need to slide the window ahead by one element.
            //  So to slide the window forward and calculate the sum of the new position of the sliding window, we need to do two things:

            //  1. Subtract the element going out of the sliding window i.e., subtract the first element of the window.
            //  2. Add the new element getting included in the sliding window i.e., the element coming right after the end of the window.

            //  This approach will save us from re - calculating the sum of the overlapping part of the sliding window.
            //  Here is what our algorithm will look like:

            //  Time Complexity #
            //  The time complexity of the above algorithm will be O(N).

            //  Space Complexity #
            //  The algorithm runs in constant space O(1).

            var windowStart = 0;
            var windowSum = 0;
            var maxSum = int.MinValue;

            for (int windowEnd = 0; windowEnd < arrItems.Length; windowEnd++)
            {
                windowSum += arrItems[windowEnd];           // Add the nexty element
                // Slide the window, we don't need to slide if we've not hit the required size of 'K'
                if (windowEnd >= k - 1)
                {
                    maxSum = Math.Max(windowSum, maxSum);
                    windowSum -= arrItems[windowStart];     // Subtract the elemnt going out
                    windowStart++;                          // Slide the window ahead
                }
            }
            return maxSum;
        }

        public int FindBruteForce(int[] arrItems, int k)
        {
            //  Time Complexity #
            //  The time complexity of the above algorithm will be O(N * k).

            //  Space Complexity #
            //  The algorithm runs in constant space O(1).

            var maxSum = int.MinValue;

            for (int i = 0; i < arrItems.Length - k; i++)
            {
                var windowSum = 0;
                for (int j = i; j < i + k; j++)
                {
                    windowSum += arrItems[j];
                }
                maxSum = Math.Max(windowSum, maxSum);
            }
            return maxSum;
        }
    }
}
