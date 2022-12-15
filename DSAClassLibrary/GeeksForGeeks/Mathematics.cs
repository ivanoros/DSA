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
        // Number of digits in a number
        // Arithmetic and Geometric Progression
        // Quadratic Equation
        // Mean and Median
        // Prime Numbers
        // LCM and HCF
        // Factorials
        // Permutation and Combinations
        // Modular Arithmetic
    }
}
