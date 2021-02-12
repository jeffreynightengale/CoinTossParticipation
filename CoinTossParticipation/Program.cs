using System;

namespace CoinTossParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hey user, please pick heads or tails. >>");
            string answer = Console.ReadLine();

            Random rand = new Random();
            int randomNum = rand.Next(1, 3); //generate a random # between 1 and 2
            int guess = 0;
            int coin;

            Console.WriteLine(randomNum);

            //1 = heads
            //2 = tails

            if (answer.ToLower() == "heads")
            {
                guess = 1;
            }
            else if (answer.ToLower() == "tails")
            {
                guess = 2;
            }

            if (randomNum == 1)
            {
                coin = 1;
                Console.WriteLine("Your coin landed on heads!");
            }
            else
            {
                coin = 2;
                Console.WriteLine("Your coin landed on tails!");
            }

            if (guess == coin)
            {
                Console.WriteLine("You guessed correctly");
            }
            else
            {
                Console.WriteLine("You guessed incorrectly");
            }
            string num = Convert.ToString(randomNum);

            Console.WriteLine("Developer Name: Jeffrey Nightengale");
        }
      
            
	}
    }

