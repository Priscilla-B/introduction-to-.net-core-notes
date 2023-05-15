using System;

namespace CSLearningProject;

class Loops
{
    public void LoopMain()
    {
        int counter = 0;
        while (counter < 10)
        {
            Console.WriteLine($"Hello World ! The counter is {counter}");
            counter++;
        }

        Console.WriteLine("\nDo ... while");
        // executes code at least once before condition is checked

        counter = 10;
        do
        {
            Console.WriteLine($"Hello World ! The counter is {counter}");
            counter++;
        } while (counter < 10);


        Console.WriteLine("\nFor Loops");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Hello World! The index is {i}");
        }

        Console.WriteLine("\nFor Loops with characters as index");

        for (char column = 'a'; column < 'k'; column++)
        {
            Console.WriteLine($"The column is {column}");
        }

        Console.WriteLine("\nCombining Loops with Branches");

        int sum = 0;
        for (int i = 0; i < 21; i++)
        { 
            if (i % 3 == 0)
            {
                sum += i;
            }
            
        }
        Console.WriteLine($"Sum of numbers is {sum}");

    }
}