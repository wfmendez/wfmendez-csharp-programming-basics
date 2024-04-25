using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        Console.WriteLine("What is your guess?");
        int guessNumber = int.Parse(Console.ReadLine());
        int attemps = 1;
        int endGame = 0;

        while (endGame == 0)
        {
            while (magicNumber != guessNumber)
            {

                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                attemps += 1;

                Console.WriteLine("What is your guess?");
                guessNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Total guess attemps: {attemps}");

            Console.WriteLine("Do you want to play again? YES/NO");
            string playAgain = Console.ReadLine();
            
            if (playAgain == "YES")
            {
                magicNumber = randomGenerator.Next(1, 100);
            }
            else if (playAgain == "NO")
            {
                endGame = 1;
            }
        }
        Console.WriteLine("END GAME");
    }

}