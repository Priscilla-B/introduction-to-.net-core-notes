// See https://aka.ms/new-console-template for more information
using System;

namespace CSLearningProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Branches priscilla = new Branches();
            // priscilla.BranchText();
            Console.WriteLine("Suprise mother....");

            Console.WriteLine("Enter first number");
            int firstNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"The first number is {firstNum}");

            Console.WriteLine("Enter second number");
            int secondNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"The second number is {secondNum}");
        
            Console.WriteLine($"The sum of your numbers is  {firstNum + secondNum}");
            Console.ReadLine();

        }
    }
}


