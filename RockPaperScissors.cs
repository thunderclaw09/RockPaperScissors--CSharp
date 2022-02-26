using System;

namespace RPS
{
    class RockPaperScissors
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int CompChoice = rnd.Next(1, 4);
            string CompChoiceS;

            if (CompChoice == 1)
            {
                CompChoiceS = "r";
            }else if (CompChoice == 2)
            {
                CompChoiceS = "p";
            } else
            {
                CompChoiceS = "s";
            }

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("Please choose either s for scissors, r for rock, and p for paper.");
            string PlayerChoice = Console.ReadLine();

            if (PlayerChoice == CompChoiceS)
            {
                Console.WriteLine("It's a tie!");
            } else if(PlayerChoice == "r" && CompChoiceS == "p")
            {
                Console.WriteLine("Computer wins!");
            }else if(PlayerChoice == "p" && CompChoiceS == "s")
            {
                Console.WriteLine("Computer wins!");
            }
            else if(PlayerChoice == "s" && CompChoiceS == "r")
            {
                Console.WriteLine("Computer wins!");
            }else if(PlayerChoice == "r" && CompChoiceS == "s")
            {
                Console.WriteLine("Player wins!");
            }else if(PlayerChoice == "p" && CompChoiceS == "r")
            {
                Console.WriteLine("Player wins!");
            }else if(PlayerChoice == "s" && CompChoiceS == "p")
            {
                Console.WriteLine("Player wins!");
            }else
            {
                Console.WriteLine("You didn't input a proper choice!");
            }

            Console.WriteLine("(Player: " + PlayerChoice + " Computer: " + CompChoiceS + ")");
            Console.ReadKey();

        }
    }
}