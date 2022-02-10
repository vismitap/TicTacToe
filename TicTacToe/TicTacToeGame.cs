using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class TicTacToeGame
    {
        public void InitGrid()
        {
            Console.WriteLine("Welcome to TicTacToe");
            char[] grid = new char[10];

            for(int i=1; i<10; i++)
            {
                grid[i] = ' ';
            }
        }

        public void DetermineXorO()
        {
            Console.WriteLine("Enter X or O");
            char entry = Convert.ToChar(Console.ReadLine());
        }
    }
}
