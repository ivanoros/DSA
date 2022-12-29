using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAClassLibrary.String
{
    public class StringADT
    {
        public string ReverseString(string str)
        {
            var reverse = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            return reverse;
        }
        public string ReverseStringJ(string str)
        {
            var reverse = new char[str.Length];

            for (int i = 0, j = str.Length - 1; i < str.Length && j >= 0; i++, j--)
            {
                reverse[i] += str[j];
            }
            return new string(reverse);
        }
        public string ReverseStringInPlace(string str)
        {
            var strCharArray = str.ToCharArray();
            int i = 0, j = strCharArray.Length - 1;

            while(i < j)
            {
                var tmp = strCharArray[i];
                strCharArray[i++] = strCharArray[j];
                strCharArray[j--] = tmp;
            }
            return new string(strCharArray);
        }

        public bool isPalindrom(string str)
        {
            int i = 0, j = str.Length - 1;
            while(i < j )
            {
                if (str[i++] != str[j--])
                    return false;
            }
            return true;
        }

        public string FindDuplicates(string str)
        {
            var duplicate = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j] && !duplicate.Contains(str[i]))
                    { 
                        duplicate += str[j]; 
                    }
                }
            }

            return duplicate.ToString();
        }
        public string FindDuplicatesHashTable(string str)
        {
            var hash = new int[26];

            for (int i = 0; i < str.Length; i++)
            {
                var ch = str[i] - 97;
                hash[ch]++;
            }
            var duplicate = string.Empty;
            for (int i = 0; i < 26; i++)
            {
                if (hash[i] > 1)
                {
                    duplicate += (char)(i + 97);
                }
            }
            return duplicate;
        }

        //  Left Shift <<
        //  Bits ORing (Merging)
        //  Bits ANDing (Masking)
        public string FindDuplicatesBits(string str)
        {
            var duplicates = string.Empty;
            var H = 0;
            for (int i = 0; i < str.Length; i++)
            {
                var X = 1;
                X = X << str[i] - 97;
                if( (X & H) > 0)
                {
                    duplicates = duplicates + str[i];
                }
                else
                {
                    H = X | H;
                }
            }

            return duplicates;
        }

        public bool AreTwoStringsAnagram(string A, string B)
        {
            if(A.Length != B.Length) return false;

            var cache = new int[26];

            for (int i = 0; i < A.Length; i++)
            {
                cache[A[i] - 97]++;
            }

            for (int i = 0; i < B.Length; i++)
            {
                cache[B[i] - 97]--;
                //if(cache[B[i] - 97] < 0)
                //    return false;
            }

            for (int i = 0; i < cache.Length; i++)
            {
                if (cache[i] != 0)
                {
                    return false;
                }
            }

            return true;

        }
    }
}
