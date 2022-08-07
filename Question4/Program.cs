using System;
using System.Numerics;
namespace PalindromicNumbers
{
    class Question3
    {
       public static void Main()
       {
        int num = 0;
        int max = 0;
        string check;
        string Rev;

        for(int i = 100 ; i < 1000 ; i++)
            {
                for(int j = 100 ; j < 1000 ; j++)
                {
                    num = i*j;
                    check = Convert.ToString(num);
                    Rev = opposite(check);

                    if(check == Rev)
                    {
                        if(num > max)
                            max = num;
                        Console.Write("The Largest palindrome Product is: " + max + "\n");
                    }
                }
            }
       }
        public static string opposite(string palindrome)
        {
            char[] cArr = palindrome.ToCharArray();
            Array.Reverse(cArr);
            return new string(cArr);
        }
    }
}