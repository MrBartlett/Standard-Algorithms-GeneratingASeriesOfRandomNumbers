using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number Memory Game!");
        Console.WriteLine("Remember the sequence of numbers and enter them correctly.");

        // Initialize variables
        List<int> numberSequence = new List<int>();
        Random random = new Random();
        //Current length of the sequence of numbers
        int sequenceLength = 1;

        while (true)
        {
            // Clear the console
            Console.Clear();

            // Generate new number sequence if needed
            if (numberSequence.Count < sequenceLength)
            {
                numberSequence.Clear();


                //// -------------------------------------------------- \\\\
                /// A for loop is missing here
                /// it needs to loop from 0 too the length of the sequence of numbers
                /// it should iterate on 1
                /// inside the list it needs to ADD a random number between 1 and 5
                /// to the list numberSequence

            }

            // Display the sequence
            Console.WriteLine("Memorize the sequence:");
            foreach (int num in numberSequence)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Thread.Sleep(2000); // Wait 2 seconds for player to memorize the sequence

            // Clear the console
            Console.Clear();

            // Prompt user for input
            Console.WriteLine("Enter the sequence:");
            bool correct = true;
            for (int i = 0; i < sequenceLength; i++)
            {
                int userInput;
                while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 5)
                {
                    Console.WriteLine("Please enter a number between 1 and 5.");
                }
                if (userInput != numberSequence[i])
                {
                    correct = false;
                    break;
                }
            }

            // Check if user input was correct
            if (correct)
            {
                Console.WriteLine("Correct! Next sequence will be longer.");
                sequenceLength++;
            }
            else
            {
                Console.WriteLine("Incorrect! Game Over.");
                break;
            }
        }
    }
}