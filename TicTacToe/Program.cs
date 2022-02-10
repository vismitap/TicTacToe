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
            Console.WriteLine("Enter\n" +
                "1: If you are a player\n" +
                "2: If you are a computer\n");
            int whichPlayer = Convert.ToInt32(Console.ReadLine());

            switch (whichPlayer)
            {
                case 1:
                     game.DetermineXorO();
                    break;

                case 2:
                    game.DetermineXorO();
                    break;

            }
        }
    }
}
