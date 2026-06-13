using ConnectFour.Models;

namespace ConnectFour.Views;

public class ConsoleView
{
    public void ShowWelcome()
    {
        Console.WriteLine("Connect Four");
    }

    public void DisplayBoard(Board board)
    {
        // Board display logic will be implemented in a later milestone.
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}
