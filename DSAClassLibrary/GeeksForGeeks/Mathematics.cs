using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAClassLibrary.GeeksForGeeks
{
    public class Mathematics
    {
        public int NumberOfDigits(long num)
        {
            if(num == 0) { return 1; }

            var digits = 0;
            //while(num > )
            while(num != 0)
            {
                num = num / 10;
                digits++;
            }
            return digits;
        }
        public int NumberOfDigitsRecursive(long num)
        {
            if (num == 0)
                return 0;

            return NumberOfDigitsRecursive(num/10) + 1;
        }
        public int NumberOfDigitsLogarithmic(long num)
        {
            return (int)Math.Floor((decimal)Math.Log10((double)num) + 1);
        }

        private int ArithmeticProgression(int n, int difference)
        {
            if(n == 0)
            {
                return 0;
            } else
            {
                return ArithmeticProgression(n - difference, difference);
            }
        }
        // Number of digits in a number
        // Arithmetic and Geometric Progression
        // Quadratic Equation
        // Mean and Median
        // Prime Numbers
        // LCM and HCF
        // Factorials
        // Permutation and Combinations
        // Modular Arithmetic

        public bool IsPalindrom(int n)
        {
            // Traverse digits from right to left to find reverse of a given numbe
            var reverse = 0;
            var original = n;
            //while(n > 0)
            while (n != 0)
            {
                var mod = n % 10;
                reverse = reverse * 10 + mod;
                n = n / 10;
            }

            return (reverse == original);
        }
    }
}
