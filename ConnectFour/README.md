# Fourward Ever - Connect Four

## Project Description
This project is a console-based Connect Four game built for SODV1202 Object-Oriented Programming. The game allows two human players to take turns dropping pieces into a 7-column by 6-row board.

## Team Name
Fourward Ever

## Team Members
- Chinonso Vincent Unegbu - GitHub: VIN-IX
- Yusuf Azeez - GitHub: yusufazeez123499-stack

## Game Rules
- The game uses a 7-column by 6-row board.
- Two players take turns.
- Player 1 uses X.
- Player 2 uses O.
- Each player chooses a column from 1 to 7.
- The piece drops to the lowest available row in that column.
- A player wins by connecting four pieces horizontally, vertically, or diagonally.
- If the board becomes full and nobody wins, the game ends in a draw.

## OOP Concepts Used
- Classes and objects
- Encapsulation
- Inheritance
- Abstraction
- Polymorphism
- Method overriding
- Arrays
- Input validation

## Main Classes
- `Program`: starts the game.
- `GameController`: controls the main game loop and turn order.
- `Board`: stores the game grid and checks valid moves, wins, and draws.
- `Player`: abstract base class for players.
- `HumanPlayer`: gets column input from the console.
- `ConsoleView`: displays messages and the board.

## Current Features
- Two-player console gameplay
- 7x6 board display
- Input validation
- Full-column validation
- Horizontal win detection
- Vertical win detection
- Diagonal win detection
- Draw detection
- Restart option after each game

## Task Allocation

| Task | Assigned member | Status |
|---|---|---|
| Repository setup and documentation | Chinonso Vincent Unegbu | Complete |
| Board model and validation | Chinonso Vincent Unegbu | Complete |
| Player classes | Yusuf Azeez | Complete |
| Game controller | Both members | Complete |
| Console view | Yusuf Azeez | Complete |
| Testing and video | Both members | In progress |

## How to Run
1. Open `ConnectFour.sln` in Visual Studio.
2. Build the solution.
3. Run the console application.
4. Follow the console instructions.
