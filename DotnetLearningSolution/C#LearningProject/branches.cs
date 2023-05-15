using System;

namespace CSLearningProject
{
    class Branches
    {
        public void BranchText()
        {
            int a = 5;
            int b = 2;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10");
            else
                Console.WriteLine("The answer is less than 10");

            bool something = 5 > 6;

            if (something)
                Console.WriteLine("something is true");
            else
                Console.WriteLine("something is false");

            int c = 5;
            int d = 3;
            int e = 4;
            if ((c + d + e > 10) && (c == d))
            // can use || for 'or' instead of && for 'and' in this example
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
        }
    }
}

   