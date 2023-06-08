using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Davaleba2X0
{
    class TicTacToe
    {
        public char[,] matrix;
        public TicTacToe()
        {
            matrix = new char[3, 3];
            InitialiseBoard();
        }
        public void InitialiseBoard()
        {
            // - ebis chawera
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                   
                    matrix[row, col] = '-';
                  
                }
                
            }
       
        }
      
        public int GetPlayerInput()
        {
            int position;

            while (true)
            {
                Console.WriteLine("select number");

                if (int.TryParse(Console.ReadLine(), out position) && position >= 1 && position <= 9)
                {
                    return position;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 9.");
                }
            }
        }


        public void Replace(int playerInput)
        {
            int row = (playerInput - 1) / 3;
            int col = (playerInput - 1) % 3;

            if (matrix[row, col] == '-')
            {
                matrix[row, col] = 'x';
            }
        }
    }
}
