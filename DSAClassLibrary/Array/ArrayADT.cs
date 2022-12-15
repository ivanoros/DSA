using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DSAClassLibrary.Array
{
    public class ArrayADT
    {
        public void Display(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void AddAppend(int[] array, int x)
        {
            //if(array.Size > length)
            //array[length++] = x;
        }
        public void Insert(int[] array, int x, int index)
        {
            if(index > 0 && index < array.Length)
            {
                for (int i = array.Length; i > index; i--)
                {
                    array[i] = array[i - 1];
                }
                array[index] = x;
                //array.length++;
            }
        }
        public void Delete(int[] array, int index)
        {
            if (index > 0 && index < array.Length)
            {
                for (int i = index; i < array.Length; i++)
                {
                    array[i] = array[i + 1];
                }
                //array.length--;
            }
        }
        private void swap(int[] array, int x, int y)
        {
            var temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }
        public int Search(int[] array, int x)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                    return i;
            }
            return -1;
        }
        public int SearchTransposition(int[] array, int x)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    if(i > 0)
                    {
                        swap(array, i, i - 1);
                        return i-1;
                    }
                    return i;
                }
            }
            return -1;
        }
        public int SearchMoveToFrontOrHead(int[] array, int x)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    swap(array, i, 0);
                    return 0;
                }
            }
            return -1;
        }
        public int BinarySearch(int[] array, int x)
        {
            int left = 0, right = array.Length - 1;
            while(left <= right)
            {
                var mid = (left + right) / 2;
                if (array[mid] == x)
                {
                    return mid;
                }
                else if (array[mid] > x)
                {
                    right = mid - 1;
                } else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
        public int BinarySearchRecursive(int[] array, int x, int left, int right)
        {
            while(left <= right)
            {
                var mid = (left + right) / 2;
                if (array[mid] == x)
                {
                    return mid;
                } else if (array[mid] < x)
                {
                    left= mid + 1;
                    return BinarySearchRecursive(array, x, left, right);
                } else
                {
                    right= mid - 1;
                    return BinarySearchRecursive(array, x, left, right);
                }
            }
            return -1;
        }
        public int Get(int[] array, int index)
        {
            if(index >= 0 && index < array.Length)
            {
                return array[index];
            }
            throw new IndexOutOfRangeException();
        }
        public int Set(int[] array, int index, int n)
        {
            if (index >= 0 && index < array.Length)
            {
                array[index] = n;
            }
            throw new IndexOutOfRangeException();
        }
        public int Max(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
        public int Min(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }
        public int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > sum)
                {
                    sum = sum + array[i];
                }
            }

            return sum;
        }
        public int SumRecursive(int[] array, int index)
        {
            if (index < 0)
            {
                return 0;
            }
            else
            {
                return SumRecursive(array, index - 1) + array[index];
            }
        }
        public float Average(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max/array.Length;
        }
        public void Reverse(int[] array)
        {
            int left = 0, right = array.Length-1;
            while (left <= right)
            {
                swap(array, left, right);
            }
        }
        public void ReverseUsingArray(int[] array)
        {
            int right = array.Length - 1;
            var newArray = new int[right];
            //Reverse into axiliary array
            for (int i = array.Length - 1, j = 0; i >= 0; i--, j++)
            {
                newArray[j] = array[i];
            }
            //Copy it back
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = newArray[i];
            }
        }
        public void LeftShift(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = 0;
        }
        public void LeftRotate(int[] array)
        {
            var firstElement = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[0] = firstElement;
            array[array.Length - 1] = 0;
        }
        public void RightShift(int[] array)
        {
            for (int i = array.Length -1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = 0;
        }
        public void RightRotate(int[] array)
        {
            var last = array[array.Length - 1];
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = last;
            array[array.Length - 1] = 0;
        }
        public void InsertIntoSorted(int[] array, int x)
        {
            for (int i = array.Length -1; i >= 0 ; i--)
            {
                if (array[i] > x)
                {
                    array[i+1] = array[i];
                }
                else
                {
                    array[i] = x;
                    break;
                }
            }
        }
        public void InsertIntoSortedWhile(int[] array, int x)
        {
            var i = array.Length - 1;
            while (array[i] > x)
            {
                array[i+ 1] = array[i];
                i--;
            }
        }
        public bool IsArraySorted(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        public void ArrangNegativeveOnLeftSide(int[] array)
        {
            int i = 0, j = array.Length - 1;
            while (i < j)
            {
                while (array[i] < 0)
                {
                    i++;
                }
                while (array[j] > 0)
                {
                    j--;
                }
                if(i < j)
                {
                    swap(array, i, j);
                }
            }
        }

        public void ArrangeNegativeOnLeftSide(int[] array)
        {
            int left = 0, right = array.Length - 1;
            while (left < right)
            {
                while (array[left] < 0) { left++; }
                while (array[right] > 0) { right--; }
                if (left < right)
                {
                    var temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
            }
        }
    }
}
