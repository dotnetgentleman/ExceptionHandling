using System;
using System.Collections.Generic;

namespace stringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Num = new List<int>();
            Num.Add(10);
            Num.Add(20);
            Num.Add(30);
            Num.Add(40);
            Num.Add(50);

            try
            {
                Console.WriteLine("Please enter a number to divide by.");
                int userInput = Convert.ToInt32(Console.ReadLine());

                foreach (int number in Num)
                {
                    Console.WriteLine(number / userInput);
                }
                Console.ReadLine();
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero.");
                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a number.");
                Console.ReadLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("The program has exited the try catch block.");

            
        }
    }
}
