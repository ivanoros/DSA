using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAClassLibrary.Leetcode
{
    //  https://leetcode.com/problems/fibonacci-number/
    //  509. Fibonacci Number
    public class FibonacciNumber
    {
        public int Fib(int n)
        {
            int previous = 0, current = 1;
            if (n <= 1)
                return n;

            var fib = 0;

            for (int i = 1; i < n; i++)
            {
                fib = previous + current;
                previous = current;
                current = fib;
            }

            return fib;
        }
    }
}
