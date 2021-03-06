namespace CodingPatternsLibrary.SlidingWindow
{
    //  Given a string with lowercase letters only, if you are allowed to replace no more than ‘k’ letters with any letter,
    //  find the length of the longest substring having the same letters after replacement.

    //  Input: String="aabccbb", k=2
    //  Output: 5
    //  Explanation: Replace the two 'c' with 'b' to have a longest repeating substring "bbbbb".

    //  Input: String="abbcb", k=1
    //  Output: 4
    //  Explanation: Replace the 'c' with 'b' to have a longest repeating substring "bbbb".

    //  Input: String="abccde", k=1
    //  Output: 3
    //  Explanation: Replace the 'b' or 'd' with 'c' to have the longest repeating substring "ccc".
    public class LongestSubstringWithSameLettersAfterReplacement
    {
        public int FindLongestSubstringLength(string input, int K)
        {
            //  This problem follows the Sliding Window pattern and we can use a similar dynamic sliding window strategy as discussed in No-repeat Substring.
            
            //  We can use a HashMap to count the frequency of each letter.
            //  We’ll iterate through the string to add one letter at a time in the window.
            //  We’ll also keep track of the count of the maximum repeating letter in any window(let’s call it maxRepeatLetterCount).
            //  So at any time, we know that we can have a window which has one letter repeating maxRepeatLetterCount times,
            //  this means we should try to replace the remaining letters.If we have more than ‘k’ remaining letters,
            //  we should shrink the window as we are not allowed to replace more than ‘k’ letters.

            //  Time Complexity #
            //  The time complexity of the above algorithm will be O(N) where ‘N’ is the number of letters in the input string.

            //  Space Complexity #
            //  As we are expecting only the lower case letters in the input string, we can conclude that the space complexity will be O(26),
            //  to store each letter’s frequency in the HashMap, which is asymptotically equal to O(1).

            var windowStart = 0;
            var charFrequency = new Dictionary<char, int>();
            var maxLength = 0;
            var maxWindowRepeatLetterCount = 0;

            for (int windowEnd = 0; windowEnd < input.Length; windowEnd++)
            {
                var rightChar = input[windowEnd];
                if (!charFrequency.ContainsKey(rightChar))
                    charFrequency[rightChar] = 0;

                charFrequency[rightChar]++;
                maxWindowRepeatLetterCount = Math.Max(maxWindowRepeatLetterCount, charFrequency[rightChar]);

                //  Current Window Size is from windowStart to windowEnd,
                //  overall we have a letter which is repeating 'maxRepeatLetterCount' times,
                //  this means we can have a window which has one letter
                //  repeating 'maxRepeatLetterCount' times and the remaining letters we should replace.
                //  If the remaining letters are more than 'K', it is time to shrink the window
                //  as we are not allowed to replace more than 'K' letters
                if (windowEnd - windowStart + 1 - maxWindowRepeatLetterCount > K)
                {
                    var leftChar = input[windowStart];
                    charFrequency[leftChar]--;
                    if (charFrequency[leftChar] == 0)
                        charFrequency.Remove(leftChar);

                    windowStart++;
                }

                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }
            return maxLength;
        }
    }
}
