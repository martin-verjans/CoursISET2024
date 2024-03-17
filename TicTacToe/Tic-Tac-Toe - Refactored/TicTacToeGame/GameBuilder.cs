namespace TicTacToeGame
{
    public class GameBuilder
    {
        public IGameUI GameUI { get; set; }
        public int GridSize { get; set; }
        public GameBuilder()
        {
        }
        public GameBuilder(IGameUI gameUI, int gridSize)
        {
            GameUI = gameUI;
            GridSize = gridSize;
        }

        public IGameController Build()
        {
            GameController controller = new GameController(GridSize)
            {
                GameUI = GameUI
            };
            return controller;
        }
    }
}
