using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        while (response == "yes")
        {
            Console.Write("What is the magic number? ");
            int magicNumber = int.Parse(Console.ReadLine());

            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            while (guess != magicNumber)
            {
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("You guessed it!");

            Console.Write("Play again? (yes/no): ");
            response = Console.ReadLine();
        }
    }
}