using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Davaleba2X0
{
    public class TicTacToe
    {
        int player = 1;
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

        public void Replace(int playerInput)
        {
            int row = (playerInput - 1) / 3;
            int col = (playerInput - 1) % 3;

            if (matrix[row, col] == '-' && (player % 2 != 0))
            {
                matrix[row, col] = 'x';
                player++;
            }
            else if (matrix[row, col] == '-')
            {
                matrix[row, col] = '0';
                player++;
            }

        }
        public bool CheckWin()
        {
            for (int row = 0; row < 3; row++)
            {
                if (matrix[row, 0] != '-' && matrix[row, 0] == matrix[row, 1] && matrix[row, 1] == matrix[row, 2])
                {
                    return true;
                }



            }
            for (int col = 0; col < 3; col++)
            {
                if (matrix[0, col] != '-' && matrix[0, col] == matrix[1, col] && matrix[1, col] == matrix[2, col])
                {
                    return true;
                }


            }
            if (matrix[0, 0] != '-' && matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2])
            {
                return true;
            }
            if (matrix[0, 2] != '-' && matrix[0, 2] == matrix[1, 1] && matrix[1, 1] == matrix[2, 0])
            {
                return true;
            }

            return false;
        }

    }
}
