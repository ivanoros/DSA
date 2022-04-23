namespace CodingPatternsLibrary.SlidingWindow
{
    //  Given an array of characters where each character represents a fruit tree, you are given
    //  two baskets and your goal is to put maximum number of fruits in each basket.
    //  The only restriction is that each basket can have only one type of fruit.

    //  You can start with any tree, but once you have started you can’t skip a tree.
    //  You will pick one fruit from each tree until you cannot, i.e.,
    //  you will stop when you have to pick from a third fruit type.

    //  Write a function to return the maximum number of fruits in both the baskets.

    //  Input: Fruit=['A', 'B', 'C', 'A', 'C']
    //  Output: 3
    //  Explanation: We can put 2 'C' in one basket and one 'A' in the other from the subarray['C', 'A', 'C']

    //  Input: Fruit=['A', 'B', 'C', 'B', 'B', 'C']
    //  Output: 5
    //  Explanation: We can put 3 'B' in one basket and two 'C' in the other basket.
    //  This can be done if we start with the second letter: ['B', 'C', 'B', 'B', 'C']


    //  Similar Problems #
    //  Problem 1: Longest Substring with at most 2 distinct characters

    //  Given a string, find the length of the longest substring in it with at most two distinct characters.

    //  Solution: This problem is exactly similar to our parent problem.
    public class MaxFruitCountOf2Types
    {
        //​ O(N) time | O(1) space
        public int FindMaxFruitCount(char[] fruits)
        {
            //  Time Complexity #
            //  The time complexity of the above algorithm will be O(N) where ‘N’ is the number of characters in the input array.
            //  The outer for loop runs for all characters and the inner while loop processes each character only once,
            //  therefore the time complexity of the algorithm will be O(N+N) which is asymptotically equivalent to O(N).

            //  Space Complexity #
            //  The algorithm runs in constant space O(1) as there can be a maximum of three types of fruits stored in the frequency map.

            var windowStart = 0;
            var maxLength = 0;
            var fruitFrequency = new Dictionary<char, int>();
            // Try to extend the range [windowStart, windowEnd]
            for (int windowEnd = 0; windowEnd < fruits.Length; windowEnd++)
            {
                var rightFruit = fruits[windowEnd];

                if (!fruitFrequency.ContainsKey(rightFruit))
                    fruitFrequency[rightFruit] = 0;

                fruitFrequency[rightFruit]++;

                // Shrink the sliding window, untill we are left with '2' fruits in the fruitFrequency
                while (fruitFrequency.Count > 2)
                {
                    var leftFruit = fruits[windowStart];
                    fruitFrequency[rightFruit]--;

                    if (fruitFrequency[rightFruit] == 0)
                        fruitFrequency.Remove(leftFruit);

                    windowStart++; // Shrink the window
                }
                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }
            return maxLength;
        }
    }
}
