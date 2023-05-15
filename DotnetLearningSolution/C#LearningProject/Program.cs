// See https://aka.ms/new-console-template for more information
using System;
// an example of an inbuilt namespace

namespace CSLearningProject
    // namespaces are used to group classes to keep them organized
{
    class Program
    {
        static void Main(string[] args)
            // main method serves as the entry point for the program
            // where the program starts basically.
            // needs to be "static", which means it doesn't change dynamically
            // as the program runs
            // "void" means the method does not return anything
            // string[] args represents a string array of arguments
        {
            Console.WriteLine("*************************Branches*******************************");
            Branches branch = new Branches();
            branch.BranchText();

            Console.WriteLine("\n*************************Loops*******************************");
            Loops loop = new Loops();
            loop.LoopMain();

            Console.WriteLine("\n*************************Collections*******************************");
            Collections collection = new Collections();
            collection.CollectionsMain();

        }
    }
}


