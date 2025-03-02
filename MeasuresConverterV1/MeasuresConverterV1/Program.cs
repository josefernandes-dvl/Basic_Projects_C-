﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasuresConverterV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;

            while (cont)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Measures Converter V1, by José Fernandes!");
                Console.Write("Enter the value that you want to convert: ");
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine("\nWhich conversion do you want to make?");
                Console.WriteLine("1-Meters to yards\n2-Centimeters to inches\n3-Kilos to pounds");
                int response = int.Parse(Console.ReadLine());
                
                switch (response)
                {
                    case 1:
                        num = 1.09361 * num;
                        Console.WriteLine("Your result is " + num + " in yards");
                        Console.WriteLine("You want to make any further conversion? (yes/no)");
                        string answer1 = Console.ReadLine().ToLower();
                        cont = answer1 == "yes";
                        break;

                    case 2:
                        num = 0.393701 * num;
                        Console.WriteLine("Your result is " + num + " in inches");
                        Console.WriteLine("You want to make any further conversion? (yes/no)");
                        string answer2 = Console.ReadLine().ToLower();
                        cont = answer2 == "yes";
                        break;

                    case 3:
                        num = 2.20462 * num;
                        Console.WriteLine("Your result is " + num + " in pounds");
                        Console.WriteLine("You want to make any further conversion? (yes/no)");
                        string answer3 = Console.ReadLine().ToLower();
                        cont = answer3 == "yes";
                        break;

                    default:
                        Console.WriteLine("Invalid Command! Try again? (yes/no)");
                        string answer4 = Console.ReadLine().ToLower();
                        cont = answer4 == "yes";
                        break;
                }
                
        }
        }
    }
}
