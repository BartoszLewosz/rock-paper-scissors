using System;
using System.Collections.Generic;
using System.Linq;

namespace rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!\nThis is a simple game of Rock - Paper - Scissors.\n");
            Console.WriteLine("(aka Ro - Sham - Bo; janken; Bato, Bato, Pick; and Scissors, Paper, Stone)\n");
            Console.WriteLine("\nThe rules:\nYou beat another player if your choice \"beats\" theirs in the following way:\n\n            Rock beats Scissors\n            Scissors beats Paper\n            Paper beats Rock");
            Console.WriteLine("\n\nEach round you score 1 for other player you beat.");
            Console.WriteLine("\nEnd of the game:\n");
            Console.WriteLine("\nAt the end of round press \'y\' to continue\n");
            Console.WriteLine("\nAny other key to exit the game.\n");
            Console.WriteLine("\nYou decide when you want to finish the game.\n");
            Console.WriteLine("\n===> In case of a Tie: <===\n");
            Console.WriteLine("\n\nNone of the players get score.\n");
            Console.WriteLine("\nScore counters will be displayed after a round on the bottom of your console.");
            Console.WriteLine("\nEnjoy the game!\n\n\n");


            string player_choice, computer_choice, loop, spell_check;
            bool play_again = true;
            int score_player = 0;
            int score_computer = 0;
            int draw = 0;
            Random rnd = new Random();

            while (play_again)
            {
                IList<string> choices = new List<string>();
                choices.Add("ROCK");
                choices.Add("PAPER");
                choices.Add("SCISSORS");

                int cIndex = rnd.Next(choices.Count);

                computer_choice = choices[cIndex];

                Console.Write("Pick your weapon:\n\nROCK, PAPER or SCISSORS?\n");

                player_choice = "";
                ConsoleKeyInfo cki = Console.ReadKey(true);

                while (cki.Key != ConsoleKey.Enter)
                {
                    player_choice += cki.KeyChar;
                    cki = Console.ReadKey(true);
                    player_choice = player_choice.ToUpper();
                }

                spell_check = ("\n===> Please check your spelling <===\n");
                if (!choices.Contains(player_choice))
                {
                    Console.WriteLine(spell_check.ToUpper());
                    continue;
                }

                Console.WriteLine("\nPlayer: {0}\n\nComputer: {1}\n", player_choice, computer_choice);

                if (player_choice == computer_choice)
                {
                    Console.WriteLine("\nIt's a TIE!");
                    draw++;
                }
                else
                {
                    if (player_choice == "ROCK" && computer_choice == "SCISSORS")
                    {
                        Console.WriteLine("You win!");
                        score_player++;
                    }
                    else if (player_choice == "PAPER" && computer_choice == "ROCK")
                    {
                        Console.WriteLine("You win!");
                        score_player++;
                    }
                    else if (player_choice == "SCISSORS" && computer_choice == "PAPER")
                    {
                        Console.WriteLine("You win!");
                        score_player++;
                    }
                    else
                    {
                        Console.WriteLine("You lose...");
                        score_computer++;
                    }
                }

                Console.WriteLine("\nPlayer: {0}\nComputer: {1}" +
                    "\nDraw: {2}", score_player, score_computer, draw);
                Console.WriteLine("\nPlay again? (y/n)");
                loop = Console.ReadLine();

                if (loop == "y")
                    play_again = true;
                else
                    play_again = false;

            }
        }
    }
}