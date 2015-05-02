using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cozalozawoza
{
    class Program
    {
        static void Main(string[] args)
        {

            int min = 1;
            int max = 110;

            for (int i = min; i <= max; i++)
            {

                if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                {
                    Console.Write(" CozaWozaLoza ");

                }
                else if ( i % 3 == 0 && i % 7 == 0)
                {
                    Console.Write(" CozaWoza ");
                }
                else if ( i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(" CozaLoza ");
                }
                else if ( i % 5 == 0 && i % 7 == 0)
                {
                    Console.Write(" LozaWoza ");
                }

                else if (i % 5 == 0)
                {
                    Console.Write(" Loza ");
                }
                else if (i % 7 == 0)
                {
                    Console.Write(" Woza ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write(" Coza ");
                }
                else
                {

                    Console.Write(String.Format("{0:# }", i));
                }
                
                if ( i % 11 == 0)
                {
                    Console.WriteLine();
                }
        

            }
            
            Console.ReadLine();

        }
    }
}
