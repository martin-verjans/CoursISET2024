namespace TicTacToeGame.GameExceptions
{
    internal class GameFinishedException : TicTacToeException
    {
        public GameFinishedException()
            :base("The game is finished, you cannot play anymore")
        {
        }
    }
}