using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, avg;

            Console.WriteLine("Enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            avg = (num1 + num2 + num3) / 3;
            Console.WriteLine($"The average of {num1},{num2}, and {num3} is {avg}");
        }
    }
}
