using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumberInWord
{
    class Program
    {
        static void Main(string[] args)
        {



            int number;

            number = int.Parse(Console.ReadLine());





            switch (number)
            {
                case 1:
                    Console.WriteLine("ONE");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("TWO");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("THREE");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("FOUR");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("FIVE");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("SIX");
                    Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("SEVEN");
                    Console.ReadLine();
                    break;
                case 8:
                    Console.WriteLine("EIGHT");
                    Console.ReadLine();
                    break;
                case 9:
                    Console.WriteLine("NINE");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("OTHER");
                    Console.ReadLine();
                    break;

            }
        }

        static void Nested(int value)
        {
            int x;
            x = int.Parse(Console.ReadLine());

            if ( x > 9)
            {
                if(x < 9)
                {
                    if (x < 8)
                    {
                        if(x < 7)
                        {
                            if(x < 6)
                            {
                                if(x < 5)
                                {
                                    if(x < 4)
                                    {
                                        if (x < 3)
                                        {
                                            if(x < 2)
                                            {
                                                Console.WriteLine("ONE");
                                            }
                                            Console.WriteLine("TWO");
                                        }
                                        Console.WriteLine("THREE");
                                    }
                                    Console.WriteLine("FOUR");
                                }
                                Console.WriteLine("FIVE");
                            }
                            Console.WriteLine("SIX");
                        }
                        Console.WriteLine("SEVEN");
                    }
                    Console.WriteLine("Eight");
                }
                Console.WriteLine("NINE");
            }
            Console.ReadLine();
                







        }
    }

}

