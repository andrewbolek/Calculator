﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_LAB3D
{
   public class Division
    {
            public void Divide()
        {
            double a;
            double b;
            double c;

            Console.WriteLine("                  --Division--\n\nEnter your first number");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Now enter the second number you would like to divide");
            double.TryParse(Console.ReadLine(), out b);

            while (b == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Your second number cannot equal 0, please enter a new number.");
                      double.TryParse(Console.ReadLine(), out b);

                }
                else { break; }
            }
            
           
            Division math = new Division();
            c = math.Math(a, b);
            Console.WriteLine($"{a} / {b} = {c}\n\n");
        start:

            Console.WriteLine("Press [1] if you would like to do another Division or [2] if you like to return to the menu");
            double answer;
            double.TryParse(Console.ReadLine(), out answer);
            if (answer == 1)
            { Divide(); }
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

            return (a / b);
        }
    }

}

