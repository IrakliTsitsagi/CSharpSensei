using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davaleba2X0
{
    internal class BoardViewer
    {
       
        public void DisplayBoard(char[,] matrix)
        {
            
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
          
        }
    }
}
