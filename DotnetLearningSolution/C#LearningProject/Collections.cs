using System;

namespace CSLearningProject;

class Collections 
{
    public void CollectionsMain()
    {
        var names = new List<string> { "<name>", "Ana", "Felipe" };

        names.Add("Bill");
        names.Add("Priscilla");
        names.Remove("Bill");


        foreach (var name in names)
        // use var for a generic variable definition
        // if you don't know/care about the type
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }

        Console.WriteLine("\nindexing lists");
        Console.WriteLine($"First name is {names[0]}");

        var index = names.IndexOf("Priscilla");
        Console.WriteLine($"Found Priscilla at index {index}");

        var index_dolly = names.IndexOf("Dolly");
        Console.WriteLine($"Found Scott at index {index_dolly}");
        // when item is not found, inedexof returns -1

        names.Sort();
        // sorts names in place alphabetically using default comparer
        // which in the case of strings, uses alphabets

        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }

        Console.WriteLine("\nList of other types");
        var fibonacciNumbers = new List<int> { 1, 1 };

        while (fibonacciNumbers.Count < 20)
        {
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);

        }

        foreach (var item in fibonacciNumbers)
        {
            Console.WriteLine(item);
        }
    }
}