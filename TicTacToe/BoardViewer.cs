namespace Davaleba2X0
{
    public class BoardViewer
    {
        public int GetPlayerInput()
        {
            int position;

            while (true)
            {
                Console.WriteLine("Select a number:");

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

        public void Draw()
        {
            Console.WriteLine("Draw!");
        }

        public void GameOver(char winner)
        {
            Console.WriteLine("Game Over!");
            Console.WriteLine(winner + " is winner!!!!!");
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
    }
}

