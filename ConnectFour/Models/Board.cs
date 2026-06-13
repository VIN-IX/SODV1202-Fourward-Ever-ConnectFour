namespace ConnectFour.Models;

public class Board
{
    public const int Rows = 6;
    public const int Columns = 7;

    private readonly char[,] _grid;

    public Board()
    {
        _grid = new char[Rows, Columns];
    }

    public bool DropDisc(int column, char symbol)
    {
        // Core board logic will be implemented in a later milestone.
        return false;
    }

    public bool IsColumnFull(int column)
    {
        // Column validation will be implemented in a later milestone.
        return false;
    }

    public void Reset()
    {
        Array.Clear(_grid, 0, _grid.Length);
    }
}
