using SecurityPlusGame.Services;

namespace SecurityPlusGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new GameManager();
            manager.InitializeScenarios();
            manager.PlayGame();
        }
    }
}
