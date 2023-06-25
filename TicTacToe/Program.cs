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
                    char winner = game.GetWinner();

                    boardViewer.GameOver(winner);

                    break;
                }

                if (game.IsDraw(counter))
                {
                    boardViewer.Draw();

                    break;
                }

            }
        }
    }
}