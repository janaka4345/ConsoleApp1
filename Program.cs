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
            Console.Write("enter your anme:");
            string name=Console.ReadLine();
            Console.WriteLine();
            Console.Write("enter your age:");

            string input_age =Console.ReadLine();

            int age=Convert.ToInt32(input_age);

            Console.WriteLine("your name is : "+name+" and your age is:"+input_age);
            if (age>20)
            {
                Console.WriteLine("your are too old");
            }else if (age>14)
            {
                Console.WriteLine("your are a teen");
            }

            Console.ReadLine();
        }
    }
}
