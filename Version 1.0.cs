using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("welcome to the game!");
                Console.WriteLine("type 'rock' 'paper' or 'scissors'");
                string playerAnswer = Console.ReadLine();
                Console.WriteLine($"you answered {playerAnswer}");
                Game game = new Game();
                String gameAnswer = game.HandGenerator();
                Console.WriteLine($"here is my answer: {gameAnswer}");


                if (gameAnswer == "rock")
                {
                    if (playerAnswer == "paper")
                        Console.WriteLine("you win!");
                    else if (playerAnswer == "scissors")
                        Console.WriteLine("you lose!");
                    else if (playerAnswer == "rock")
                        Console.WriteLine("we tie!");
                }
                else if (gameAnswer == "paper")
                {
                    if (playerAnswer == "scissors")
                        Console.WriteLine("you win!");
                    else if (playerAnswer == "rock")
                        Console.WriteLine("you lose!");
                    else if (playerAnswer == "paper")
                        Console.WriteLine("we tie!");
                }
                else if (gameAnswer == "scissors")
                {
                    if (playerAnswer == "rock")
                        Console.WriteLine("you win!");
                    else if (playerAnswer == "paper")
                        Console.WriteLine("you lose!");
                    else if (playerAnswer == "scissors")
                        Console.WriteLine("we tie!");
                }

                Console.WriteLine(" ");
            }
        }

    }




    class Game
    {
        public int RandomGenerator()
        {
            Random randomNumber = new Random();
            int result = randomNumber.Next(0, 4);
            return result;
        }

        public string HandGenerator()
        {
            string result;
            int resultnumber = RandomGenerator();
            if (resultnumber == 1)
                return result = "rock";
            else if (resultnumber == 2)
                return result = "paper";
            else
                return result = "scissors";
        }
    }
       
}
