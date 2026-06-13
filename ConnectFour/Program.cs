using ConnectFour.Controllers;

namespace ConnectFour;

internal class Program
{
    static void Main(string[] args)
    {
        GameController gameController = new GameController();
        gameController.Start();
    }
}
