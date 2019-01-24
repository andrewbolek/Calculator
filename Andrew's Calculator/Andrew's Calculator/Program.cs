using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_LAB3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Andrew's Calculator.\n\n");
            Calculator();
        
        }
        static void Calculator()
        {
        start:
            Console.WriteLine("Please enter one of the following numbers to use that operator...");
            Console.WriteLine("  [1]--Addition--(+)\n\n  [2]--Subtraction--(-)\n\n  [3]--Multiplication--(*)\n\n  [4]--Divison--(/)\n\n                Enter any other key to exit...");
            double result;
            double.TryParse(Console.ReadLine(), out result);
            if (result == 1)
            {
                Addition add = new Addition();
                add.Add();
                goto start;
            }
            if (result == 2)
            {
                Subtraction sub = new Subtraction();
                sub.Subtract();
                goto start;
            }
            if (result == 3)
            {
                Multiplication multiply = new Multiplication();
                multiply.Multiply();
                goto start;
            }
            if (result == 4)
            {
                Division divide = new Division();
                divide.Divide();
                goto start;
            }
            else
            {
                Console.WriteLine("Thanks for stopping by!");
                Console.ReadLine();

            }


        }
    }
}
