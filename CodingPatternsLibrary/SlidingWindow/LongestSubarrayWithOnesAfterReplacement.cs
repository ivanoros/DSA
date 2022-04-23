namespace CodingPatternsLibrary.SlidingWindow
{
    //  Given an array containing 0s and 1s, if you are allowed to replace no more than ‘k’ 0s with 1s,
    //  find the length of the longest contiguous subarray having all 1s.

    //  Input: Array=[0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1], k=2
    //  Output: 6
    //  Explanation: Replace the '0' at index 5 and 8 to have the longest contiguous subarray of 1s having length 6.

    //  Input: Array=[0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1], k=3
    //  Output: 9
    //  Explanation: Replace the '0' at index 6, 9, and 10 to have the longest contiguous subarray of 1s having length 9.
    public class LongestSubarrayWithOnesAfterReplacement
    {
        public int FindLongestSubarray(int[] arrItems, int K)
        {
            //  Time Complexity #
            //  The time complexity of the above algorithm will be O(N) where ‘N’ is the count of numbers in the input array.

            //  Space Complexity #
            //  The algorithm runs in constant space O(1).

            var maxLength = 0;
            var windowStart = 0;
            var maxOnesCount = 0;

            for (int windowEnd = 0; windowEnd < arrItems.Length; windowEnd++)
            {
                if (arrItems[windowEnd] == 1)
                    maxOnesCount++;

                //  Current Window Size is from windowStart to windowEnd,
                //  overall we have a maximum of 1s repeating a maximum of 'maxOnesCount' times,
                //  this means that we can have a window with 'maxOnesCount' 1s
                //  and the remaining are 0s which we should replace with 1s.
                //  If the remaining 0s are more than 'K', it is time to shrink the window
                //  as we are not allowed to replace more than 'K' 0s
                if (windowEnd - windowStart + 1 - maxOnesCount > K)
                {
                    if (arrItems[windowStart] == 1)
                        maxOnesCount--;

                    windowStart++;
                }

                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }
            return maxLength;
        }
    }
}
