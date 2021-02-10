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

            Console.WriteLine(randomNum);

            if (randomNum == 1)
            {
                Console.WriteLine("Your coin landed on heads!");
            }
            else
            {
                Console.WriteLine("Your coin landed on tails!");
            }
        }
      
            
	}
    }

