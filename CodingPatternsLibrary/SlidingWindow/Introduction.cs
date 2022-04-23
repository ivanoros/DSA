namespace CodingPatternsLibrary.SlidingWindow
{
    //  https://www.youtube.com/watch?v=MK-NZ4hN7rs
    //  https://medium.com/outco/how-to-solve-sliding-window-problems-28d67601a66

    //  In general, any problem where the author is asking for any of the following return values can use a sliding window:
    //  1. Minimum value
    //  2. Maximum value
    //  3. Longest value
    //  4. Shortest value
    //  5. K-sized value

    //  Furthermore, a question that uses a list or data type that must be iterated over in sequence is a great candidate for a sliding window.
    //  The previous question also met this criteria, as it had an array input and needed to be iterated over sequentially.

    //  Lastly, one of the biggest clues that one can use a sliding window is the word contiguous.
    //  Remember: in the context of programming, contiguous means that the elements are sequentially placed next to each other.

    //  Some common data structures one will be using a sliding window on are strings, arrays, and even linked lists.

    // Given an array, find the average of all contiguous subarrays of size ‘K’ in it.

    // Input: [1, 3, 2, 6, -1, 4, 1, 8, 2], K=5
    // Output: [2.2, 2.8, 2.4, 3.6, 2.8]
    public class Introduction
    {
        //​ O(N) time | O(1) space
        public double[] FindAverageOfContiguousSubArrays(int[] arrItems, int K)
        {
            // The efficient way to solve this problem would be to visualize each contiguous subarray as a sliding
            // window of ‘5’ elements.This means that when we move on to the next subarray, we will slide the
            // window by one element. So, to reuse the sum from the previous subarray, we will subtract the element
            // going out of the window and add the element now being included in the sliding window.This will save us
            // from going through the whole subarray to find the sum and, as a result,
            // the algorithm complexity will reduce to O(N).

            int windowStart = 0;
            int windowSum = 0;
            double[] averageOfContiguousSubArrays = new double[arrItems.Length - K + 1];
            for (int windowEnd = 0; windowEnd < arrItems.Length; windowEnd++)
            {
                windowSum += arrItems[windowEnd];                                       // Add the next element
                // Slide the window, we don't need to slide if we've not hit the required window size of 'k'
                if (windowEnd >= K - 1)
                {
                    averageOfContiguousSubArrays[windowStart] = windowSum / (double)K;  // Calculate the average
                    windowSum -= arrItems[windowStart];                                 // Subtract the element going out
                    windowStart++;                                                      // Slide the window ahead
                }
            }

            return averageOfContiguousSubArrays;
        }
    }
}
