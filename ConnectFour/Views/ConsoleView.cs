using ConnectFour.Models;

namespace ConnectFour.Views;

public class ConsoleView
{
    public void ShowWelcome()
    {
        Console.Clear();
        Console.WriteLine("Fourward Ever - Connect Four");
        Console.WriteLine("Connect four pieces horizontally, vertically, or diagonally to win.");
        Console.WriteLine();
    }

    public void DisplayBoard(Board board)
    {
        Console.WriteLine();

        for (int row = 0; row < Board.Rows; row++)
        {
            for (int column = 0; column < Board.Columns; column++)
            {
                Console.Write("| " + board.GetCell(row, column) + " ");
            }

            Console.WriteLine("|");
        }

        Console.WriteLine("-----------------------------");
        Console.WriteLine("  1   2   3   4   5   6   7");
        Console.WriteLine();
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public bool AskToPlayAgain()
    {
        Console.WriteLine();
        Console.WriteLine("Play again? Enter y for yes or any other key to exit:");
        string? input = Console.ReadLine();

        return input != null && input.ToLower() == "y";
    }
}
