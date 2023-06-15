namespace Davaleba2X0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToe game = new TicTacToe();
            BoardViewer boardViewer = new BoardViewer();

            int counter = 0;
            while (game.CheckWin() != true)
            {

                boardViewer.DisplayBoard(game.matrix);

                int playerInput = boardViewer.GetPlayerInput();

                game.Replace(playerInput);

                counter++;

                if (game.CheckWin() == true)
                {
                    boardViewer.GameOver();
                    break;
                }

                if (counter == 9 && game.CheckWin() == false)
                {
                    boardViewer.Draw();
                    break;
                }

            }
        }
    }
}