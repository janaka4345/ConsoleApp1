using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number to looo fizzbuzz");
            int number = Convert.ToInt32( Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i%3==0)
                {
                    Console.Write("fizz");
                }
                if (i % 5 == 0)
                {
                    Console.Write("buzz");
                }
                if (i % 5 == 0 || i % 3 == 0)
                {
                Console.WriteLine("");
                }
                else
                {

                Console.WriteLine(i);
                }


            }
            Console.ReadLine();
        }
    }
}
