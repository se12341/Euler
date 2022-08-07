using System;
using System.Numerics;
namespace NoRemainder
{
    class Question5
    {
       static void Main()
       {
        int m = 100;
        Boolean t;
        while(m > 1)
        {
            t = NoRemainder(m);
            if(t == true)
                Console.Write(m);
            m++;
        }
       }

       public static Boolean NoRemainder(int number)
       {
            for(int i = 1 ; i < 20 ; i++)
            {
                if(number % i != 0 )
                    return false;

            }
        return true;
       }
    }
}