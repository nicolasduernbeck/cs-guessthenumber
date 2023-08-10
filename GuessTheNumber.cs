using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 20);
            bool guessed = false;

            while (!guessed)
            {
                Console.WriteLine("Make your guess!");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == randomNumber)
                {
                    guessed = true;
                    Console.WriteLine("You guessed the number!");
                } else if (randomNumber > guess)
                {
                    Console.WriteLine("Too low!");
                } else
                {
                    Console.WriteLine("Too high!");
                }
            }
        }
    }
}
