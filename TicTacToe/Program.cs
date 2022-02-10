using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame game = new TicTacToeGame();
            game.InitGrid();
            Random random = new Random();
            int whichPlayer = random.Next(1, 3);

            switch (whichPlayer)
            {
                case 1:
                    Console.WriteLine("Player is a human");
                     game.DetermineXorO();
                    break;

                case 2:
                    Console.WriteLine("Player is a computer");
                    game.DetermineXorO();
                    break;

            }
        }
    }
}
