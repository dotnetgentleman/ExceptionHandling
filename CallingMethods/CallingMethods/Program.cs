using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number you would like to do math with.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(userInput + " plus 75 is " + Calculation.Addition(userInput));
            Console.WriteLine(userInput + " minus 12 is " + Calculation.subtraction(userInput));
            Console.WriteLine(userInput + " divided by 2 is " + Calculation.division(userInput));
        }
    }
}
