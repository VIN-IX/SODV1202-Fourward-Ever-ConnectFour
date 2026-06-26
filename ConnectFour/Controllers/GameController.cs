using ConnectFour.Models;
using ConnectFour.Players;
using ConnectFour.Views;

namespace ConnectFour.Controllers;

public class GameController
{
    private readonly Board _board;
    private readonly ConsoleView _view;
    private readonly Player _playerOne;
    private readonly Player _playerTwo;

    public GameController()
    {
        _board = new Board();
        _view = new ConsoleView();
        _playerOne = new HumanPlayer("Player 1", 'X');
        _playerTwo = new HumanPlayer("Player 2", 'O');
    }

    public void Start()
    {
        bool playAgain = true;

        while (playAgain)
        {
            _board.Reset();
            Player currentPlayer = _playerOne;
            bool gameOver = false;

            _view.ShowWelcome();

            while (!gameOver)
            {
                _view.DisplayBoard(_board);

                int column = currentPlayer.ChooseColumn(_board, _view);
                _board.DropDisc(column, currentPlayer.Symbol);

                if (_board.HasWinner(currentPlayer.Symbol))
                {
                    _view.DisplayBoard(_board);
                    _view.ShowMessage(currentPlayer.Name + " wins!");
                    gameOver = true;
                }
                else if (_board.IsFull())
                {
                    _view.DisplayBoard(_board);
                    _view.ShowMessage("The game is a draw.");
                    gameOver = true;
                }
                else
                {
                    currentPlayer = SwitchPlayer(currentPlayer);
                }
            }

            playAgain = _view.AskToPlayAgain();
        }

        _view.ShowMessage("Thanks for playing!");
    }

    private Player SwitchPlayer(Player currentPlayer)
    {
        if (currentPlayer == _playerOne)
        {
            return _playerTwo;
        }

        return _playerOne;
    }
}
