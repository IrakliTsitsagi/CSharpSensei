using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davaleba2X0
{
    public class BoardViewer
    {
        public int GetPlayerInput()
        {
            int position;
            int counter = 0;

            while (true)
            {
                Console.WriteLine("Select a number:");

                if (int.TryParse(Console.ReadLine(), out position) && position >= 1 && position <= 9)
                {
                    counter++;
                    return position;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 9.");
                }
            }

            return 0;
        }
        public void Draw()
        {
            Console.WriteLine("Draw!");
        }
        public void GameOver()
        {
            Console.WriteLine("Game Over!");
        }
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
    }// mainidan displays ushveb isev da iman ra unda qnas abaa :D
}

