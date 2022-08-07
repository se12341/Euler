using System;
using System.Numerics;
namespace EvenFibonacci 
{
    class Question2
    {
       static void Main()
       {
            int total = 0;
            int a = 1;
            int b = 1;
            int ph = a + b;
            int limiter = 4000000;

            while(b < limiter)
                {
                    total = total + ph ; 
                    a = b + ph ; 
                    b = ph + a ;
                    ph = a + b;
                }
            Console.Write(total);
       }
    }
}