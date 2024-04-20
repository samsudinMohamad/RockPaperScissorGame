using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    internal class Game
    {
        private Player[] _players;
        private int _round = 1;
        public Game()
        {
            _players = new Player[2];
            _players[0] = new Player("Player One");
            _players[1] = new Player("Player Two");
        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Round: {_round}");
                Console.WriteLine("---------");
                Console.WriteLine($"{_players[0].Name} Score: {_players[0].Score}");
                Console.WriteLine($"{_players[1].Name} Score: {_players[1].Score}");
                Console.WriteLine();
                Console.WriteLine("Valid Choice: Rock, Paper, Scissor");
                foreach (var player in _players)
                {
                    Console.WriteLine();
                    player.Choice = PromptUserChoice(player.Name);
                    Console.WriteLine();
                }
                GetResult(_players[0], _players[1]);
                _round++;
            }
        }
        private string PromptUserChoice(string name)
        {
            string? choice;
            ConsoleColor currentColor;
            do
            {
                Console.WriteLine($"{name} turn to pick, Pick your Weapon wisely!");
                currentColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Black;
                choice = Console.ReadLine()?.ToLower();
                Console.ForegroundColor = currentColor;
            } while (!(choice == "scissor" || choice == "rock" || choice == "paper"));
            return choice;
        }

        private void GetResult (Player playerOne, Player playerTwo)
        {
            switch (playerOne.Choice, playerTwo.Choice)
            {
                case ("scissor","paper"):
                    Console.WriteLine($"{playerOne.Name} Wins!");
                    playerOne.Score++;
                    break;
                case ("rock", "paper"):
                    Console.WriteLine($"{playerTwo.Name} Wins!");
                    playerTwo.Score++;
                    break;
                case ("paper", "scissor"):
                    Console.WriteLine($"{playerTwo.Name} Wins!");
                    playerTwo.Score++;
                    break;
                case ("rock", "scissor"):
                    Console.WriteLine($"{playerOne.Name} Wins!");
                    playerOne.Score++;
                    break;
                case ("paper", "rock"):
                    Console.WriteLine($"{playerOne.Name} Wins!");
                    playerOne.Score++;
                    break;
                case ("scissor", "rock"):
                    Console.WriteLine($"{playerTwo.Name} Wins!");
                    playerTwo.Score++;
                    break;
                default:
                    Console.WriteLine("Draw!");
                    break;
            }
        }
    }
}
