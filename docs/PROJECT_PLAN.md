# Connect Four Project Plan

## Required behaviour

- Use a board with 7 columns and 6 rows.
- Allow players to select columns from 1 to 7.
- Reject invalid input and full columns without crashing.
- Alternate between two players.
- Check for horizontal, vertical, and diagonal wins.
- Detect a draw.
- Return to a start screen after the game ends.

## OOP plan

### Abstraction
The controller communicates with the board, players, and view through clear public methods.

### Encapsulation
The board grid and game state remain private. Other classes use methods such as `DropDisc()` and `CheckWinner()` instead of changing the grid directly.

### Inheritance
`HumanPlayer` inherits from the abstract `Player` class. A `ComputerPlayer` may be added later.

### Polymorphism
The controller can work with a variable of type `Player` while the actual object may be a `HumanPlayer` or future `ComputerPlayer`.

## Suggested branch names

- `feature/board-model`
- `feature/player-classes`
- `feature/game-controller`
- `feature/console-view`
- `fix/full-column-validation`
