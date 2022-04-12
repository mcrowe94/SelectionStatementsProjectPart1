using System;

namespace SelectionStatementsProjectPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rng = new Random();
            int randomNumber = rng.Next(1, 1000);
            while (true)
            {
                Console.WriteLine("Welcome to your random number generator!");
                Console.WriteLine("A random number has been selected! Can you guess the correct number?");
                

                string input = Console.ReadLine();
                int userGuess = int.Parse(input);

                if (userGuess == randomNumber)
                {
                    Console.WriteLine($"Correct! Press enter to exit!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if (userGuess > randomNumber)
                {
                    Console.WriteLine($"Too high, try again!");
                }
                else if (userGuess < randomNumber)
                {
                    Console.WriteLine($"Too low, try again!");                    
                }               
            }

        }
    }
}

