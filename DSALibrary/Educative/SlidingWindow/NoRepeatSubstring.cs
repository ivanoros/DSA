namespace DSALibrary.Educative.SlidingWindow
{
    //  Given a string, find the length of the longest substring which has no repeating characters.

    //  Input: String="aabccbb"
    //  Output: 3
    //  Explanation: The longest substring without any repeating characters is "abc".

    //  Input: String="abbbb"
    //  Output: 2
    //  Explanation: The longest substring without any repeating characters is "ab".

    //  Input: String="abccde"
    //  Output: 3
    //  Explanation: Longest substrings without any repeating characters are "abc" & "cde".
    public class NoRepeatSubstring
    {
        //​ O(N) time | O(1) space
        public int FindNoRepeatSubstring(string input)
        {
            //  Time Complexity #
            //  The time complexity of the above algorithm will be O(N) where ‘N’ is the number of characters in the input string.

            //  Space Complexity #
            //  The space complexity of the algorithm will be O(K) where KK is the number of distinct characters in the input string.
            //  This also means K <= N, because in the worst case, the whole string might not have any repeating character
            //  so the entire string will be added to the HashMap.
            //  Having said that, since we can expect a fixed set of characters in the input string(e.g., 26 for English letters),
            //  we can say that the algorithm runs in fixed space O(1);
            //  in this case, we can use a fixed-size array instead of the HashMap.

            var windowStart = 0;
            int maxLenghth = 0;
            var charFrequency = new Dictionary<char, int>();
            // Try to extend the range [windowStart, windowEnd]
            for (int windowEnd = 0; windowEnd < input.Length; windowEnd++)
            {
                var rightChar = input[windowEnd];
                // If the Dictionary already contains 'rightChar',
                // Shrink the window from the beginning
                // so that we have only one
                // occurence of 'rightChar'
                if (charFrequency.ContainsKey(rightChar))
                {
                    // This is tricky
                    // In the current window, we will not have any 'rightChar' after its previous index
                    // and if 'windowStart' is already ahead of the last index of 'rightChar',
                    // we will keep 'windowStart'
                    windowStart = Math.Max(windowStart, charFrequency[rightChar] + 1);
                }

                charFrequency[rightChar] = windowEnd; // Insert the 'rightChar' into dictionary
                maxLenghth = Math.Max(maxLenghth, windowEnd - windowStart + 1); // Remember the maximum lengh so far
            }
            return maxLenghth;
        }

        public int FindNoRepeatSubstringUsingHashSet(string str)
        {
            var longest = 0;
            var windowStart = 0;
            var chars = new HashSet<char>();
            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                var rightChar = str[windowEnd];
                if (!chars.Contains(rightChar))
                {
                    chars.Add(rightChar);
                }
                else
                {
                    while (chars.Contains(rightChar))
                    {
                        var leftChar = str[windowStart++];
                        chars.Remove(leftChar);
                    }
                }
                longest = Math.Max(longest, windowEnd - windowStart + 1);
            }
            return longest;
        }
    }
}
