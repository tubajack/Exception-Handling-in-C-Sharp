using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intro_C_Sharp_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 12;
            int second = 0;
            Console.WriteLine("Enter your first number: ");
            first = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            second = System.Int32.Parse(Console.ReadLine());

            int result = first / second;
            Console.WriteLine($"The result of dividing {first} by {second} is {result}");
            
        }

        static int Divide(int first, int second)
        {
            int result = 0;
            try
            {
                result = first / second;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero. ");
                Console.WriteLine("Please provide a non-zero value for your second parameter");
            }
            return result;
        }
       
    }
}
