using ConnectFour.Models;
using ConnectFour.Views;

namespace ConnectFour.Players;

public class HumanPlayer : Player
{
    public HumanPlayer(string name, char symbol)
        : base(name, symbol)
    {
    }

    public override int ChooseColumn(Board board, ConsoleView view)
    {
        while (true)
        {
            view.ShowMessage($"{Name} ({Symbol}), choose a column from 1 to 7:");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int selectedColumn))
            {
                view.ShowMessage("Invalid input. Please enter a number from 1 to 7.");
                continue;
            }

            int columnIndex = selectedColumn - 1;

            if (!board.IsValidColumn(columnIndex))
            {
                view.ShowMessage("Invalid column. Please choose a number from 1 to 7.");
                continue;
            }

            if (board.IsColumnFull(columnIndex))
            {
                view.ShowMessage("That column is full. Please choose another column.");
                continue;
            }

            return columnIndex;
        }
    }
}
