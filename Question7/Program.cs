using System;
using System.Numerics;
namespace BigPrime
{
    class Question7
    {
       static void Main()
       {
            BigInteger i = 2;
            int sum = 1;
            while(sum <= 10001)
            {
                if(PrimeCheck(i))
                {
                    Console.Write(i + "\n");
                    sum++;
                    //Console.Write(sum + "\n");
                }
                i++;
            }

       }
       public static bool PrimeCheck(BigInteger naor)
       {
        for(BigInteger j = 2 ; j < naor ; j++)
        {
            if(naor % j == 0)
            {
                return false;
            }
        }
        return true;
       }       
    }
}