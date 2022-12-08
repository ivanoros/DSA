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

        public int SumOfNaturalNumbersLoop(int n)
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
    }
}
