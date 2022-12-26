namespace DSAClassLibrary.Array
{
    public class ArrayADT
    {
        public void AddAppend(int[] array, int x)
        {
            //if(array.Size > length)
            //array[length++] = x;
        }
        public void Insert(int[] array, int x, int index)
        {
            if (index > 0 && index < array.Length)
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
        public int LinearSearch(int[] array, int x)
        {
            for (int i = 0; i < array.Length; i++)
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
                    if (i > 0)
                    {
                        swap(array, i, i - 1);
                        return i - 1;
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
            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (array[mid] == x)
                {
                    return mid;
                }
                else if (array[mid] > x)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
        public int BinarySearchRecursive(int[] array, int x, int left, int right)
        {
            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (array[mid] == x)
                {
                    return mid;
                }
                else if (array[mid] < x)
                {
                    left = mid + 1;
                    return BinarySearchRecursive(array, x, left, right);
                }
                else
                {
                    right = mid - 1;
                    return BinarySearchRecursive(array, x, left, right);
                }
            }
            return -1;
        }
        public int Get(int[] array, int index)
        {
            if (index >= 0 && index < array.Length)
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

            return max / array.Length;
        }
        public void Reverse(int[] array)
        {
            int left = 0, right = array.Length - 1;
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
            for (int i = 0; i < array.Length - 1; i++)
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
            for (int i = array.Length - 1; i > 0; i--)
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
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > x)
                {
                    array[i + 1] = array[i];
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
                array[i + 1] = array[i];
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
                if (i < j)
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

        public int[] Merge(int[] first, int[] second)
        {
            // Merging can only be done on sorted arrays
            var merged = new int[first.Length + second.Length];
            int i = 0, j = 0, z = 0;

            while (i < first.Length && j < second.Length)
            {
                if (first[i] < second[j])
                {
                    merged[z++] = first[i++];
                }
                else
                {
                    merged[z++] = second[j++];
                }

            }

            for (; i < first.Length; i++)
            {
                merged[z++] = first[i];
            }

            for (; j < second.Length; j++)
            {
                merged[z++] = second[j];
            }

            return merged;
        }
        // Append
        // Concat
        // Compare
        // Copy

        // Set Operations

        // O(n2) Time Complexety 
        public int[] Union(int[] first, int[] second)
        {
            // Duplicate are selected only once
            var union = new int[first.Length + second.Length - 2];
            int k = 0;
            for (int i = 0; i < first.Length; i++)
            {
                union[k++] = first[i];
            }
            for (int j = 0; j < second.Length; j++)
            {
                var isDuplicate = false;
                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] == second[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    union[k++] = second[j];
                }
            }
            return union;
        }

        // O(n) Time Complexety
        public int[] UnionOnSorted(int[] first, int[] second)
        {
            // Duplicate are selected only once
            var union = new int[first.Length + second.Length - 2];
            int i = 0, j = 0, k = 0;

            while (i < first.Length && j < second.Length)
            {
                if (first[i] == second[j])
                {
                    union[k++] = first[i];
                    i++;
                    j++;
                }
                else if (first[i] < second[j])
                {
                    union[k++] = first[i];
                    i++;
                }
                else
                {
                    union[k++] = second[j];
                    j++;
                }
            }

            for (; i < first.Length; i++)
            {
                union[k++] = first[i];
            }

            for (; j < second.Length; j++)
            {
                union[k++] = second[j];
            }
            return union;
        }

        // O(n2) Time Complexety
        public int[] Intersection(int[] first, int[] second)
        {
            // Common elemnts of both sets
            //var intersection = new int[first.Length + second.Length - 2];
            var intersection = new int[2];
            int k = 0;

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if (first[i] == second[j])
                    {
                        intersection[k++] = first[i];
                        break;
                    }
                }
            }
            return intersection;
        }

        // O(n) Time Complexety
        public int[] IntersectionOnSorted(int[] first, int[] second)
        {
            // Common elemnts of both sets
            //var intersection = new int[first.Length + second.Length - 2];
            var intersection = new int[2];
            int i = 0, j = 0, k = 0;

            while (i < first.Length && k < second.Length)
            {
                if (first[i] == second[j])
                {
                    intersection[k++] = first[i];
                    i++;
                    j++;
                }
                else if (first[i] < second[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }

            }
            return intersection;
        }

        // O(n2) Time Complexety
        public int[] Difference(int[] first, int[] second)
        {
            // A - B
            // We want all elemnt of A that are not in B
            //var difference = new int[first.Length + second.Length - 2];
            var difference = new int[3];
            int k = 0;

            for (int i = 0; i < first.Length; i++)
            {
                var foundInSecond = false;
                for (int j = 0; j < second.Length; j++)
                {
                    if (first[i] == second[j])
                    {
                        foundInSecond = true;
                        break;
                    }
                }
                if (!foundInSecond)
                {
                    difference[k++] = first[i];
                }
            }

            return difference;
        }

        // O(n) Time Complexety
        public int[] DifferenceOnSorted(int[] first, int[] second)
        {
            // A - B
            // We want all elemnt of A that are not in B
            //var difference = new int[first.Length + second.Length - 2];
            var difference = new int[3];
            int i = 0, j = 0, k = 0;

            while (i < first.Length && j < second.Length)
            {
                if (first[i] == second[j])
                {
                    i++;
                    j++;
                }
                else if (first[i] < second[j])
                {
                    difference[k++] = first[i];
                    i++;
                }
                else
                {
                    j++;
                }
            }

            for (; i < first.Length; i++)
            {
                difference[k++] = first[i];
            }

            return difference;
        }

        public bool SetMembership(int[] array, int n)
        {
            // Verify wether elemnt belong to the set or not
            // It is the same as searching
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                    return true;
            }
            return false;
        }

        // n*(n+1)/2 this is the formula for sum of N natural numbers
        public int[] FindMissingElement(int[] array)
        {
            var number = array.Length;
            var low = array[0];
            var high = array[number - 1];
            var difference = low - 0;
            var missing = new int[high - low - number + 1];
            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                var actualDifference = array[i] - i;
                while (difference != actualDifference)
                {
                    missing[k++] = i + difference;
                    difference++;
                }
            }

            return missing;
        }

        public int[] FindMissingElementWhile(int[] array)
        {
            var number = array.Length;
            var low = array[0];
            var high = array[number - 1];
            var difference = low - 0;
            var missing = new int[high - low - number + 1];
            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                var actualDifference = array[i] - i;
                if (difference != actualDifference)
                {
                    while (difference < array[i] - i)
                    {
                        missing[k++] = i + difference;
                        difference++;
                    }
                }
            }

            return missing;
        }

        // Time complexity is O(n)
        // Space complexity is O(n)
        public int[] FindMissingElementExtraArray(int[] array)
        {
            var number = array.Length; // Number of elements
            int low = int.MaxValue; // Lowest number in the input array
            int high = int.MinValue; // // Highest number in the input array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > high)
                    high = array[i];

                if (array[i] < low)
                    low = array[i];
            }

            var hashValues = new int[high + 1];
            var missing = new int[high - low - number + 1];
            int k = 0;

            for (int i = 0; i < number; i++)
            {
                hashValues[array[i]]++;
            }

            for (int i = low; i <= high; i++)
            {
                if (hashValues[i] == 0)
                {
                    missing[k++] = i;
                }
            }

            return missing;
        }

        public int[] FindDuplicatesInSortedArray(int[] array)
        {
            var duplicates = new List<int>();
            var lastDuplicate = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1] && array[i] != lastDuplicate)
                {
                    lastDuplicate = array[i];
                    duplicates.Add(array[i]);
                }
            }
            return duplicates.ToArray();
        }

        public Dictionary<int, int> FindDuplicatesInSortedArrayWithCount(int[] array)
        {
            var duplicateCounts = new Dictionary<int, int>();
            var j = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    j = i + 1;
                    while (array[i] == array[j])
                    {
                        j++;
                    }
                    duplicateCounts.Add(array[i], j - i);
                    i = j - 1;
                }
            }

            return duplicateCounts;
        }

        public Dictionary<int, int> FindDuplicatesInSortedArrayWithCountUsingHashing(int[] array)
        {
            var maxElement = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                    maxElement = array[i];
            }

            var hashArray = new int[maxElement + 1];

            for (int i = 0; i < array.Length; i++)
            {
                hashArray[array[i]]++;
            }

            var duplicateCounts = new Dictionary<int, int>();
            for (int i = 0; i < hashArray.Length; i++)
            {
                if (hashArray[i] > 1)
                {
                    duplicateCounts.Add(i, hashArray[i]);
                }
            }

            return duplicateCounts;
        }

        public Dictionary<int, int> FindDuplicatesInUnSortedArray(int[] array)
        {
            var duplicates = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (duplicates.TryGetValue(array[i], out int duplicateKey))
                    continue;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        if (duplicates.TryGetValue(array[i], out int duplicate))
                        {
                            duplicates[array[i]]++;
                        }
                        else
                        {
                            duplicates[array[i]] = 2;
                        }
                    }
                }
            }

            return duplicates;
        }

        public int[] FindPairWithSumKQuadratic(int[] array, int k)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == k)
                    {
                        return new int[] { array[i], array[j] };
                    }
                }
            }
            return new int[2] { -1, -1 };
        }

        public int[] FindPairWithSumK(int[] array, int k)
        {
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                var diff = k - array[i];
                if (dictionary.TryGetValue(diff, out int value))
                {
                    return new int[] { value, array[i] };
                }
                else
                {
                    dictionary[array[i]] = array[i];
                }
            }
            return new int[2] { -1, -1 };
        }

        public int[] FindPairWithSumKInSortedArray(int[] array, int k)
        {
            int i = 0, j = array.Length - 1;
            while (i < j)
            {
                if (array[i] + array[j] == k)
                    return new int[] { array[i], array[j] };
                else if (array[i] + array[j] > k)
                    j--;
                else
                    i++;
            }
            return new int[] { -1, -1 };
        }

        public int[] FindMaxAndMinInSingleScan(int[] array)
        {
            var min = array[0];
            var max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                else if (array[i] < min)
                    min = array[i];
            }
            return new int[] { min, max };
        }
    }
}
