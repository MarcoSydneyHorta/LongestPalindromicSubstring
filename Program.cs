using System;

namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string st = Console.ReadLine();
            if (st.Length > 1 && st != null)
            {
                Console.WriteLine("The longest palindromic substring is: " + longPalin(st));
            }
            else
            {
                Console.WriteLine("The string must be at least 2 characters long");
            }
            static  String longPalin(String st)
            {
                int arise = 0, end = 0;
                for (int i = 0; i < st.Length - 1; i++)
                {
                    int len1 = calcCenter(st, i, i);
                    int len2 = calcCenter(st, i, i + 1);
                    int len = Math.Max(len1, len2);
                    if (len > end - arise)
                    {
                        arise = i - (len - 1) / 2;
                        end = i + len / 2;
                    }
                }

                return st.Substring(arise, end);
            }
            static int calcCenter(String s, int left, int right)
            {
                int L = left;
                int R = right;
                char[] sC = s.ToCharArray(0, s.Length);
                while (L >= 0 && R < s.Length && sC[L] == sC[R]) 
                {
                    L--;
                    R++;
                }
                return R - L - 1;
            }
        }
    }
}

