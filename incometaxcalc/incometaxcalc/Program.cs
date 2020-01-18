using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IncomeTaxCalculator
{
    class IncomeTaxV2
    {
        public static void Main()
        {
            bool validinput;
            double income = 0.0;
            do
            {
                Console.Write("What is your total income: ");
                
                if (double.TryParse(Console.ReadLine(), out double gross) && gross >= 0.0)
                {
                    validinput = true;
                    income = gross;
                    
                }
                else
                {
                    validinput = false;
                    Console.WriteLine("Your income cannot be a negative.");
                }
            } while (!validinput);


            bool validinput2;
            int dependants = 0;
            do
            {

                Console.Write("How many children do you have: ");
                if (int.TryParse(Console.ReadLine(), out int kids) && kids >= 0)
                {
                    validinput2 = true;
                    dependants = kids;
                 
                }
                else
                {
                    validinput2 = false;
                    Console.WriteLine("You must enter a positive number.");
                }
            } while (!validinput2);

            for (int y = 0; y < dependants; y++)
            {
                income = income - 2000;
            }

            double taxpayable = (income - 10000) * 0.02;
            if (taxpayable <= 0)
            {
                Console.WriteLine("You owe no tax.");
            }
            else
            {
                Console.WriteLine("You owe a total of {0:C} tax.", taxpayable);
            }
            

            Console.WriteLine("\n\n Hit Enter to exit.");
            Console.ReadLine();
        }
    }
}