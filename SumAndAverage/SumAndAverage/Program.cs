using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {

            UInt64 Add = 0;
            UInt64 x;
            UInt64 y;
            

            
            

            Console.Write("Please Enter First Integer : ");
            x = UInt64.Parse(Console.ReadLine());

            Console.Write("Please Enter Second Integer : ");
            y = UInt64.Parse(Console.ReadLine());

          
                for (UInt64 i = x; i <= y; i++)
                {
                   

                    Add = Add + i;

                }
              
                
           
            
            var sum = (Decimal.Add(x, y) / 2);

            var count = (y - x);



            UInt64 odd = 0;
            UInt64 seven = 0;
            UInt64 oddmean;
            for (var counter = x; counter <= y; counter ++ )
            {

                if (counter % 2 == 1)
                {
                    odd += counter;

                    
                }
                if (counter % 7 == 0)
                {
                    seven += counter;
                    

                }
                

            }
            oddmean = ((odd / (count / 2)));

            UInt64 square = 0;
            for (var i = x; i <= y; i++)
            {
                square = square + i * i;

            }










                Console.WriteLine("The sum is " + Add);
            Console.WriteLine("The average is " + sum.ToString("#.##"));
            Console.WriteLine("The amount of integers between " + x + " and " + y + " is " + count);
            Console.WriteLine("Sum of odd numbers from " + x +  " to " + y +  " is " + odd);
            Console.WriteLine("Avarage of the odd numbers is " + oddmean);
            Console.WriteLine("Sum of all numbers divisible by 7 is " + seven);

            Console.WriteLine("Sum of squares from " + x + " to " + y + " is " + square);



            Console.ReadLine();


        }
    }
}
