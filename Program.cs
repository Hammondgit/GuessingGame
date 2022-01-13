using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerLimit = 1;
            int upperLimit = 101;

            Random answerGenerator = new Random();
            int answer = answerGenerator.Next(lowerLimit, upperLimit);

            string instructions = $"Please choose a number between {lowerLimit} and {upperLimit-1}.\n";

            Console.WriteLine("GUESSING GAME");
            Console.WriteLine(instructions);
            bool hasWon = false;

            for (int count = 0; count < 3; count++)
            {
                Console.WriteLine("Guess a number: ");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == answer)
                {
                    hasWon = true;
                    count = 3; // this will end the loop
                }
                else if (userGuess == 0)
                {
                    // print out instructions
                    Console.WriteLine(instructions);
                }
                else
                {
                    //Console.WriteLine("Oh no, you lost!");
                    //Console.WriteLine("That's not correct! Please try again.\n");

                    if(userGuess < answer)
                    {
                        Console.WriteLine("Your number is lower than the right answer.\n");
                    }else if(userGuess > answer)
                    {
                        Console.WriteLine("Your number is higher than the right answer.\n");
                    }

                }
            }

            if (hasWon)
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine($"Oh no, you lost! The correct answer was {answer}");
            }
           
        }
    }
}
