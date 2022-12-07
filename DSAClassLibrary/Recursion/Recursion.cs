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

        #endregion TreeRecursion

        #region IndirectRecursion
        #endregion IndirectRecursion

        #region NestedRecursion
        #endregion NestedRecursion

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
    }
}
