using System;
using System.Numerics;
namespace ThreesAndFives
{
    class Question1
    {
       static void Main()
       {
            int threes = 0 ;
            int fives = 0 ;
            int sum = 0; 
            for(int i = 0 ; i < 1000 ; i++)
            {
                if(i % 3 == 0 && i % 5 != 0)
                    threes = threes + i ;
                if(i % 5 == 0 )
                   fives = fives + i ;

                sum = threes + fives ;
            }
        Console.Write(sum);
       }
    }   
}