namespace ConnectFour.Models;

public class Board
{
    public const int Rows = 6;
    public const int Columns = 7;
    private const char EmptyCell = '.';

    private readonly char[,] _grid;

    public Board()
    {
        _grid = new char[Rows, Columns];
        Reset();
    }

    public char GetCell(int row, int column)
    {
        return _grid[row, column];
    }

    public bool IsValidColumn(int column)
    {
        return column >= 0 && column < Columns;
    }

    public bool IsColumnFull(int column)
    {
        return _grid[0, column] != EmptyCell;
    }

    public bool DropDisc(int column, char symbol)
    {
        if (!IsValidColumn(column) || IsColumnFull(column))
        {
            return false;
        }

        for (int row = Rows - 1; row >= 0; row--)
        {
            if (_grid[row, column] == EmptyCell)
            {
                _grid[row, column] = symbol;
                return true;
            }
        }

        return false;
    }

    public bool IsFull()
    {
        for (int column = 0; column < Columns; column++)
        {
            if (!IsColumnFull(column))
            {
                return false;
            }
        }

        return true;
    }

    public bool HasWinner(char symbol)
    {
        return HasHorizontalWin(symbol)
            || HasVerticalWin(symbol)
            || HasDiagonalDownWin(symbol)
            || HasDiagonalUpWin(symbol);
    }

    private bool HasHorizontalWin(char symbol)
    {
        for (int row = 0; row < Rows; row++)
        {
            for (int column = 0; column <= Columns - 4; column++)
            {
                if (_grid[row, column] == symbol &&
                    _grid[row, column + 1] == symbol &&
                    _grid[row, column + 2] == symbol &&
                    _grid[row, column + 3] == symbol)
                {
                    return true;
                }
            }
        }

        return false;
    }

    private bool HasVerticalWin(char symbol)
    {
        for (int row = 0; row <= Rows - 4; row++)
        {
            for (int column = 0; column < Columns; column++)
            {
                if (_grid[row, column] == symbol &&
                    _grid[row + 1, column] == symbol &&
                    _grid[row + 2, column] == symbol &&
                    _grid[row + 3, column] == symbol)
                {
                    return true;
                }
            }
        }

        return false;
    }

    private bool HasDiagonalDownWin(char symbol)
    {
        for (int row = 0; row <= Rows - 4; row++)
        {
            for (int column = 0; column <= Columns - 4; column++)
            {
                if (_grid[row, column] == symbol &&
                    _grid[row + 1, column + 1] == symbol &&
                    _grid[row + 2, column + 2] == symbol &&
                    _grid[row + 3, column + 3] == symbol)
                {
                    return true;
                }
            }
        }

        return false;
    }

    private bool HasDiagonalUpWin(char symbol)
    {
        for (int row = 3; row < Rows; row++)
        {
            for (int column = 0; column <= Columns - 4; column++)
            {
                if (_grid[row, column] == symbol &&
                    _grid[row - 1, column + 1] == symbol &&
                    _grid[row - 2, column + 2] == symbol &&
                    _grid[row - 3, column + 3] == symbol)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public void Reset()
    {
        for (int row = 0; row < Rows; row++)
        {
            for (int column = 0; column < Columns; column++)
            {
                _grid[row, column] = EmptyCell;
            }
        }
    }
}
