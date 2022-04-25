namespace CodingPatternsLibrary.SlidingWindow
{
    public class MinimumWindowSubstring
    {
        public string FindMinimumWindowSubstring(string input, string substring)
        {
            var windowStart = 0;
            var lettersNeeded = new Dictionary<char, int>();
            var lettersSean = new Dictionary<char, int>();
            var lettersMissing = 0;
            var result = (windowStart: 0, windowEnd: int.MaxValue);
            foreach (var ch in substring)
            {
                if (!lettersNeeded.ContainsKey(ch))
                {
                    lettersNeeded[ch] = 0;
                    lettersMissing++;
                }
                lettersNeeded[ch] += 1;
                lettersSean[ch] = 0;
            }

            for (int windowEnd = 0; windowEnd < input.Length; windowEnd++)
            {
                var rightChar = input[windowEnd];
                if (lettersNeeded.ContainsKey(rightChar))
                {
                    lettersSean[rightChar] += 1;
                    if(lettersSean[rightChar] == lettersNeeded[rightChar])
                    {
                        lettersMissing -= 1;
                    }
                }

                while (lettersMissing == 0)
                {
                    var leftChar = input[windowStart];
                    if (windowEnd - windowStart < result.windowEnd - result.windowStart)
                    {
                        result = (windowStart: windowStart, windowEnd: windowEnd);
                    }

                    if (lettersNeeded.ContainsKey(leftChar))
                    {
                        lettersSean[leftChar] -= 1;

                        if (lettersSean[leftChar] < lettersNeeded[leftChar])
                        {
                            lettersMissing += 1;
                        }
                    }

                    windowStart++;
                }
            }

            if (result.windowEnd == int.MaxValue)
                return string.Empty;
            else
                return input.Substring(result.windowStart, result.windowEnd - result.windowStart + 1);
        }
    }
}
