using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Program
    {
        static char choiceXorOHuman, choiceXorOComp;
        static void Main(string[] args)
        {
            TicTacToeGame game = new TicTacToeGame();
            game.InitGrid();

            Console.WriteLine("Human is starting the Game...");
            choiceXorOHuman = game.DetermineXorO();

            switch (choiceXorOHuman)
            {
                case 'O':
                    choiceXorOComp = 'X';
                    break;

                case 'X':
                    choiceXorOComp = 'O';
                    break;

                default:
                    Console.WriteLine("Enter Valid input. Either X or O");
                    break;
            }
        }
    }
}
