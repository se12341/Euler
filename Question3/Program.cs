using System;
using System.Numerics;
namespace Primes
{
    class Question3
    {
       static void Main()
       {
        BigInteger menash = 600851475143 ;
        for(BigInteger i = 50 ; i <= menash ; i++)
            {
                if(PrimeCheck(i))
                    {
                        if(menash % i == 0)
                        {
                        Console.Write(" this number is a prime: " + i + "\n");
                        }
                    }
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