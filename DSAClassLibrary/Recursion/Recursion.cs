using System.Security;

namespace DSAClassLibrary.Recursion
{
    // Every Recursive function can be converted as a Lopp
    // And vice versa evry Loop can be converted as a Recursive function
    public class Recursion
    {
        #region TailRecursion
        // If the Recursion Call is the last statement in the function
        // Time --> O(n)
        // Space --> O(n)
        public void TailRecursion(int n)
        {
            if(n > 0)
            {
                Console.WriteLine(n);
                TailRecursion(n - 1);
            }
        }

        // Time --> O(n)
        // Space --> O(1)
        // In case of Tail Recursion the Loop is more efficient in the terms of Space
        // Space is Order of One instead of Order of N
        public void LoopTailRecursion(int n)
        {
            while(n > 0)
            {
                Console.WriteLine(n);
                n = n - 1;
            }
        }
        #endregion TailRecursion

        #region HeadRecursion
        // If The first statement in the function is the Recursion call it is called Head Recursion
        // No processing is done at the time of calling
        // All of the processing is done at the time of returning
        public void HeadRecursion(int n)
        {
            if (n > 0)
            {
                HeadRecursion(n - 1);
                Console.WriteLine(n);
            }
        }
        public void LoopHeadRecursion(int n)
        {
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        #endregion HeadRecursion

        #region TreeRecursion
        // Linear Recursion is the function that it is calling itself only one time
        // If a Function calling itself more than one times than it is a Tree Recursion

        public void TreeRecursion(int n)
        {
            if(n > 0)
            {
                Console.WriteLine(n);
                TreeRecursion(n - 1);
                TreeRecursion(n - 1);
            }
        }
        #endregion TreeRecursion

        #region IndirectRecursion
        // In indirect recursion, there is more than one functions that call each other in the circular fashion

        public void FunctionA(int n)
        {
            if(n > 0)
            {
                Console.WriteLine(n);
                FunctionB(n - 1);
            }
        }

        public void FunctionB(int n)
        {
            if(n > 1)
            {
                Console.WriteLine(n); ;
                FunctionA(n / 2);
            }
        }
        #endregion IndirectRecursion

        #region NestedRecursion
        // In a nested Recursion, The recursive function will pass a paramter as Recursive call

        public int NestedRecursion(int n)
        {
            if (n > 100)
                return n - 10;
            else
                return NestedRecursion(NestedRecursion(n + 11));
        }

        #endregion NestedRecursion

        #region RecursionWithStaticVariable
        private static int x = 0;
        public int RecursionWithStaticVariable(int n)
        {
            if(n > 0)
            {
                x++;
                return RecursionWithStaticVariable(n - 1) + x;
            }
            return 0;
        }

        private int y = 0;
        public int RecursionWithGloabVariable(int n)
        {
            if (n > 0)
            {
                y++;
                return RecursionWithGloabVariable(n - 1) + y;
            }
            return 0;
        }
        #endregion RecursionWithStaticVariable

        #region Sum Of N Natural Numbers
        public int SumOfNaturalNumbers(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            else
            {
                return SumOfNaturalNumbers(n - 1) + n;
            }
        }

        public int SumOfNaturalNumbersIterative(int n)
        {
            var sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum = sum + n;
            }

            return sum;
        }

        public int SumOfNaturalNumbersFormula(int n)
        {
            return n * (n + 1) / 2;
        }
        #endregion Sum Of N Natural Numbers

        #region Factorial
        public int Factorial(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            else
            {
                return Factorial(n - 1) * n;
            }
        }

        public int FactorialIterative(int n)
        {
            var factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
        #endregion Factorial

        #region Exponent
        public int Power(int m, int n)
        {
            if (n > 0)
            {
                return Power(m, n - 1) * m;
            }
            else
            {
                return 1;
            }
        }

        public int PowerEnhanced(int m, int n)
        {
            if (n > 0)
            {
                if(n % 2 == 0)
                {
                    return PowerEnhanced(m * m, n / 2);
                }
                else
                {
                    return PowerEnhanced(m * m, (n - 1)/2) * m;
                }
            }
            else
            {
                return 1;
            }
        }
        #endregion Exponent

        #region Fibonacci Series
        // 0 1 2 3 4 5 6 7
        // 0 1 1 2 3 5 8 13
        public int Fibonacci(int n)
        {
            if(n <= 1 )
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 2) + Fibonacci(n - 1);
            }
        }

        public int FibonacciIterative(int n)
        {
            if (n <= 1)
                return n;

            int sum = 0, previous = 0, current = 1;
            for(int i = 2; i <= n; i++)
            {
                sum = previous + current;
                previous = current;
                current = sum;
            }
            return sum;
        }

        private Dictionary<int, int> _fibValues = new Dictionary<int, int>();

        // Recursion that is being called multiple times is called Excessive Recursion
        // Memoisation is storing the results
        public int FibonacciCached(int n)
        {
            if (n <= 1)
            {
                _fibValues[n] = n;
                return n;
            }
            else
            {
                if (!_fibValues.TryGetValue(n - 2, out int fibValue2))
                {
                    _fibValues[n - 2] = FibonacciCached(n - 2);
                }
                if (!_fibValues.TryGetValue(n - 1, out int fibValue1))
                {
                    _fibValues[n - 1] = FibonacciCached(n - 1);
                }

                _fibValues[n] = _fibValues[n - 2] + _fibValues[n - 1];

                return _fibValues[n - 2] + _fibValues[n - 1];

                //if (_fibValues.TryGetValue(n, out int fibValue))
                //{
                //    return fibValue;
                //}
                //else
                //{
                //    fibValue = FibonacciCached(n - 2) + FibonacciCached(n - 1);
                //    _fibValues[n] = fibValue;
                //    return fibValue;
                //}
            }
        }
        #endregion Fibonacci Series

        #region Combination Formula
        // Permutation Formula
        // nCr = n!/(r!(n-r)!)

        public int CombinationFormula(int n, int r)
        {
            int t1, t2, t3;
            t1 = Factorial(n);
            t2 = Factorial(r);
            t3 = Factorial(n - r);
            return t1 / (t2 * t3);
        }

        public int NCR(int n, int r)
        {
            if(r==0 || n == r)
            {
                return 1;
            }
            else
            {
                return NCR(n - 1, r - 1) + NCR(n - 1, r);
            }
        }
        #endregion Combination Formula

        #region Tower of Hanoi
        public void TowerOfHanoi(int n, int A, int B, int C)
        {
            if(n > 0)
            {
                TowerOfHanoi(n - 1, A, C, B);
                Console.WriteLine($"Move from ({A} --> {C})");
                TowerOfHanoi(n - 1, B, A, C);
            }
        }
        #endregion Tower of Hanoi
    }
}
