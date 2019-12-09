using System;

namespace rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game rules.");

            string player_choice, computer_choice;
            bool play_again = true;
            int score_player = 0;
            int score_computer_choice = 0;
            int draw = 0;
            Random rnd = new Random();

            //while (play_again)
            {
                string[] choices = { "ROCK", "PAPER", "SCISSORS" };
                int cIndex = rnd.Next(choices.Length);

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
                Console.WriteLine("\nPlayer: {0}\n\nComputer: {1}", player_choice, computer_choice);

                if (player_choice == computer_choice)
                {
                    Console.WriteLine("draw case");
                }
                else
                {
                    Console.WriteLine("other cases");
                }
            }
        }
    }
}