using System;

namespace CSLearningProject
{
    class String
    {
        static void Main(string[] args)
        {
            string firstFriend = "Maria";
            // declaration of varible type as 'string' on assignment
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            // interpolated string with '$' instead of 'f' in python

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            // uses .Length property to get length of string

            // string methods
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");
            // empty spaces within a string definition gets printed to console

            // examples of string methods for trimming strings
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            // replacing string

            // the "Replace" method searches for the given substring and replaces it with the given text
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            // changing the case of a string
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            // searching strings
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            // returns true
            Console.WriteLine(songLyrics.Contains("greetings"));
            // returns false

            Console.WriteLine(songLyrics.StartsWith("You say"));
            // check for existence of substring at beginning of string
            Console.WriteLine(songLyrics.EndsWith("say hello"));
            // check for existence of substring at end of string
        }
    }
}
