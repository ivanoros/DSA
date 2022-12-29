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

        public long Factorial(int n)
        {
            long factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial*= i;
            }

            return factorial;
        }

        public int FactorialRecursive(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return FactorialRecursive(n - 1) * n;
            }
        }

        public int GreatestCommonDivisor(int a, int b)
        {
            var result = Math.Min(a, b);
            while (result > 0)
            {
                if(a % result == 0 && b%result == 0)
                {
                    break;
                }
                result--;
            }
            return result;
        }

        //  Euclidean Algorithm
        //  gcd(a,b) = gcd(a-b, b)
        public int GreatestCommonDivisorEuclidean(int a, int b)
        {
            while(a != b)
            {
                if(a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }

            return a;
        }

        public int GreatestCommonDivisorEuclideanOptimized(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return GreatestCommonDivisorEuclideanOptimized(b, a % b);
        }

        // The smallest number that is divisable by both numbers
        public int LeastCommonMultiple(int a, int b)
        {
            var result = Math.Max(a, b);

            while (true)
            {
                if(result % a == 0
                    && result % b == 0)
                {
                    return result;
                }

                result++;
            }
        }

        // a*b = gcd(a,b) * lcm(a,b)
        public int LeastCommonMultipleEfficient(int a, int b)
        {
            return (a * b) / GreatestCommonDivisorEuclideanOptimized(a, b);
        }

        //  A number Is Prime if it is divisable only by itself or 1
        //  First Few Prome Numbers
        //  2, 3, 5, 7, 11, 13, 17, 19
        public bool IsPrimeNumber(int n)
        {
            if (n == 1)
                return false;

            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsPrimeNumberEfficient(int n)
        {
            if (n == 1)
                return false;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsPrimeNumberMoreEfficient(int n)
        {
            if (n == 1)
                return false;

            if (n == 2 || n == 3)
                return true;

            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i = i + 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //  Prime factors are deiviser fo the number that are primes
        public int[] PrimeFactors(int n)
        {
            var result = new List<int>();

            for (int i = 2; i < n; i++)
            {
                if (IsPrimeNumberMoreEfficient(i))
                {
                    var x = i;
                    while( n % x == 0)
                    {
                        result.Add(x);
                        x = x * i;
                    }
                }
            }

            return result.ToArray();
        }

        public int[] PrimeFactorsEfficient(int n)
        {
            if (n <= 1)
                return new int[] { -1 };

            var result = new List<int>();

            for (int i = 2; i * i <= n; i++)
            {
                if (IsPrimeNumberMoreEfficient(i))
                {
                    var x = i;
                    while (n % x == 0)
                    {
                        result.Add(x);
                        n = n / i;
                    }
                }
            }

            if(n > 1)
            {
                result.Add(n);
            }

            return result.ToArray();
        }

        public int[] PrimeFactorsMoeEfficient(int n)
        {
            if (n <= 1)
                return new int[] { -1 };

            var result = new List<int>();

            while(n % 2 == 0)
            {
                result.Add(2);
                n = n / 2;
            }

            while (n % 3 == 0)
            {
                result.Add(3);
                n = n / 3;
            }

            for (int i = 5; i * i <= n; i = i + 6)
            {
                while (n % i == 0)
                {
                    result.Add(i);
                    n = n / i;
                }
                while (n % (i + 2) == 0)
                {
                    result.Add(i + 2);
                    n = n / (i + 2);
                }
            }

            if (n > 3)
            {
                result.Add(n);
            }

            return result.ToArray();
        }

    }
}
