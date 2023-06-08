namespace Davaleba2X0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TicTacToe game = new TicTacToe();
            BoardViewer boardViewer = new BoardViewer();

            while (true)
            {
                boardViewer.DisplayBoard(game.matrix);

                int playerInput = game.GetPlayerInput();
                game.Replace(playerInput);
               
            }
        }
    }
}