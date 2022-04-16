namespace DSALibrary.Educative.SlidingWindow
{
    //  Problem Statement #
    //  Given a string, find the length of the longest substring in it with no more than K distinct characters.

    //  Input: String= "araaci", K= 2
    //  Output: 4
    //  Explanation: The longest substring with no more than '2' distinct characters is "araa".

    //  Input: String= "araaci", K= 1
    //  Output: 2
    //  Explanation: The longest substring with no more than '1' distinct characters is "aa".

    //  Input: String= "cbbebi", K= 3
    //  Output: 5
    //  Explanation: The longest substrings with no more than '3' distinct characters are "cbbeb" & "bbebi".
    public class LongestSubstringWIthKDistinctChars
    {
        //​ O(N) time | O(K) space
        public int FindLongestSubstringWIthKDistinctChars(string input, int K)
        {
            //  Time Complexity #
            //  The time complexity of the above algorithm will be O(N) where ‘N’ is the number of characters in the input string.
            //  The outer for loop runs for all characters and the inner while loop processes each character only once,
            //  therefore the time complexity of the algorithm will be O(N+N) which is asymptotically equivalent to O(N).

            //  Space Complexity #
            //  The space complexity of the algorithm is O(K), as we will be storing a maximum of ‘K + 1’ characters in the HashMap.

            if (string.IsNullOrWhiteSpace(input) || input.Length < K)
                return -1;


            var windowStart = 0;
            var maxLenghth = 0;
            var charFrequencyMap = new Dictionary<char, int>();
            // In the following loop we'll try to extend the range [windowStart, windowEnd]
            for (int windowEnd = 0; windowEnd < input.Length; windowEnd++)
            {
                var rightChar = input[windowEnd];
                if (!charFrequencyMap.ContainsKey(rightChar))      // Initialize with Zero count
                    charFrequencyMap[rightChar] = 0;

                charFrequencyMap[rightChar]++;                     // Increment Characters Count

                // Shrink the window, untill we are left with 'K' distinct characters in the frequency Dictionary
                while (charFrequencyMap.Count > K)
                {
                    var leftChar = input[windowStart];
                    charFrequencyMap[leftChar] = charFrequencyMap[leftChar] - 1;

                    if (charFrequencyMap[leftChar] == 0)
                        charFrequencyMap.Remove(leftChar);

                    windowStart++;                              // Shrink the window
                }
                maxLenghth = Math.Max(maxLenghth, windowEnd - windowStart + 1); // Remember the maximum length so far
            }
            return maxLenghth;
        }
    }
}
