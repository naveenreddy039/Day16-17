using System;

namespace StringEquals
{
    class Main
    {
        public static bool checkEquality(String[] s1, String[] s2)
        {
            if (s1 == s2)
            {
                return true;
            }
            if (s1 == null || s2 == null)
            {
                return false;
            }
            int n = s1.Length;
            if (n != s2.Length)
            {
                return false;
            }
            for (int i = 0; i < n; i++)
            {
                if (!s1[i].Equals(s2[i]))
                {
                    return false;
                }
            }
            return true;
        }
        class program
        {
            static void Main(String[] args)
            {
                String[] s1 = { "n", "a", "v","e","e","n" };
                String[] s2 = { "r", "e", "d","d","y" };
                if (checkEquality(s1, s2))
                {
                    Console.WriteLine("Both arrays are equal");
                }
                else
                {
                    Console.WriteLine("Both arrays are not equal");
                }
            }
        }
    }

    
}
