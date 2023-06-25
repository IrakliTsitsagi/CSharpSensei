using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Davaleba2X0
{
    public class TicTacToe
    {
        public int CountX { get; set; } = 0;
        public int Count0 { get; set; } = 0;

        int player = 1;
        public char[,] matrix;

        public TicTacToe()
        {
            InitialiseBoard();
        }
        public void InitialiseBoard()
        {
            matrix = new char[3, 3];
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
        private void CountXand0()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (matrix[row, col] == 'x')
                    {
                        CountX++;
                    }
                    else if (matrix[row, col] == '0')
                    {
                        Count0++;
                    }
                }
            }
        }

        public char GetWinner() 
        {
            if (IsXWinner())
            {
                return 'x';
            }

            return '0';
        }

        private bool IsXWinner()
        {
            CountXand0();

            if (CountX > Count0)
            {
                return true;

            }

            return false;
        }
        
        public bool CheckWin()
        {
            if (CheckRow())
            {
                return true;
            }
            else if (CheckCol())
            {
                return true;
            }
            else if (CheckDiagonal())
            {
                return true;
            }

            return false;

            //return CheckRow() || CheckCol() || CheckDiagonal(); esec shemoklebuli variantia zemot rac giweria
        }

        public bool IsDraw(int numberOfMoves)
        {
            if (numberOfMoves == 9 && CheckWin() == false)
            {
                return true;
            }

            return false;

            //if (numberOfMoves == 9 && !CheckWin()) es igivea rac zeda  ra ver gaige naxe axla checkwin xo abrunebs trues tu mogebaa 
            //{

            //}

            //return numberOfMoves == 9 && !CheckWin(); es yvelaze shemoklebuli variantia gadaxede da meore taski gaq dasawyebixo. is funqcia momewona LD romel
        }

        public bool CheckRow()
        {
            for (int row = 0; row < 3; row++)
            {
                if (matrix[row, 0] != '-' && matrix[row, 0] == matrix[row, 1] && matrix[row, 1] == matrix[row, 2])
                {
                    return true;
                }
            }

            return false;
        }

        public bool CheckCol()
        {
            for (int col = 0; col < 3; col++)
            {
                if (matrix[0, col] != '-' && matrix[0, col] == matrix[1, col] && matrix[1, col] == matrix[2, col])
                {
                    return true;
                }
            }

            return false;
        }

        public bool CheckDiagonal()
        {
            if (matrix[0, 0] != '-' && matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2])
            {
                return true;
            }
            else if (matrix[0, 2] != '-' && matrix[0, 2] == matrix[1, 1] && matrix[1, 1] == matrix[2, 0])
            {
                return true;
            }

            return false;
        }
    }
}