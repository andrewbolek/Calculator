using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_LAB3D
{
    public class Subtraction
    {
            public void Subtract()
        {
            double a;
            double b;
            double c;
            Console.WriteLine("                  --Subtraction--\n\nEnter your first number");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Now enter the second number you would like to subtract");
            double.TryParse(Console.ReadLine(), out b);
            Subtraction math = new Subtraction();
            c = math.Math(a, b);
            Console.WriteLine($"{a} - {b} = {c}\n\n");
        start:
            Console.WriteLine("Press [1] if you would like to do another Subtraction or [2] if you like to return to the menu");
            double answer;
            double.TryParse(Console.ReadLine(), out answer);
            if (answer == 1)
            { Subtract(); }
            if (answer == 2)
            { goto end; }
            else
            {
                Console.WriteLine("\n-----Invalid choice, Try again.-----\n\n");
                goto start;
            }

        end:;


        }





        private double Math(double a, double b)
        {

            return (a - b);
        }
    }

}
