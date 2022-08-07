using System;
using System.Numerics;
namespace SqrAndSum
{
    class Question6
    {
       static void Main()
       {
        double sum = 0; 
        double sqr = 0;
        double total = 0;
            for(int i = 1 ; i <= 100 ; i++)
            {
                sum = sum + Math.Pow(i , 2);
                sqr = sqr + i;
            }
        sqr = Math.Pow(sqr, 2);
        total = sqr - sum;
        Console.Write(total);
       }
    }
}