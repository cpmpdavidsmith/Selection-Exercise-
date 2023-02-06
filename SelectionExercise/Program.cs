// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace SelectionSExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------EXERCISE 1---------------------------   
            var favNumber = 5;
            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} too high");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

        }

    }
}

