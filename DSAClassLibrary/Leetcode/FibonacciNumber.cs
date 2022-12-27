﻿namespace DSAClassLibrary.Leetcode
{
    //  https://leetcode.com/problems/fibonacci-number/
    //  509. Fibonacci Number

    //  The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, such that each number is the sum of the two preceding ones, starting from 0 and 1. That is,
    //  F(0) = 0, F(1) = 1
    //  F(n) = F(n - 1) + F(n - 2), for n > 1.
    //  Given n, calculate F(n).
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
