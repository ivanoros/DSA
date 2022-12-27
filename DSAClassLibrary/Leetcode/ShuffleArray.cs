namespace DSAClassLibrary.Leetcode
{
    //  https://leetcode.com/problems/shuffle-the-array/
    //  1470. Shuffle the Array

    //  Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
    //  Return the array in the form[x1, y1, x2, y2, ..., xn, yn].

    public class ShuffleArray
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var array = new int[nums.Length];
            var indx = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i < n)
                {
                    array[indx++] = nums[i];
                    array[indx++] = nums[i + n];
                }
            }

            return array;
        }

        public int[] ShuffleIandJ(int[] nums, int n)
        {
            var array = new int[nums.Length];
            var indx = 0;
            for (int i = 0, j = n; i < n && j < nums.Length; i++, j++){
                array[indx++] = nums[i];
                array[indx++] = nums[j];
            }
            return array;
        }
    }
}
