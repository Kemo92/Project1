using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPassFail
{
    class Program
    {
        static void Main(string[] args)
        {

            int y = 50;
            int mark;

            Console.WriteLine("Please enter a number and press enter");
            mark = int.Parse(Console.ReadLine());

            if (mark >= y)
            {
                Console.WriteLine("PASS");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("FAIL");
                Console.ReadLine();
            }







        }
    }
}
