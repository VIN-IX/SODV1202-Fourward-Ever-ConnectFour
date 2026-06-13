using ConnectFour.Models;
using ConnectFour.Views;

namespace ConnectFour.Controllers;

public class GameController
{
    private readonly Board _board;
    private readonly ConsoleView _view;

    public GameController()
    {
        _board = new Board();
        _view = new ConsoleView();
    }

    public void Start()
    {
        _view.ShowWelcome();
        _view.ShowMessage("Initial project structure is ready.");
    }
}
