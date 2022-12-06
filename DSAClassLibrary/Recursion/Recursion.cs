namespace DSAClassLibrary.Recursion
{
    public class Recursion
    {
        public void HeadRecursion(int n)
        {
            if (n > 0)
            {
                HeadRecursion(n - 1);
                Console.WriteLine(n);
            }
        }

        public void TailRecursion(int n)
        {
            if(n > 0)
            {
                Console.WriteLine(n);
                TailRecursion(n - 1);
            }
        }

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
