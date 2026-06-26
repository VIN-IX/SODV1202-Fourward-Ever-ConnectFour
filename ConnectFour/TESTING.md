# Testing Notes

## Test 1: Valid Column Input
Input: a number from 1 to 7  
Expected result: the piece drops into the selected column.

## Test 2: Invalid Text Input
Input: letters such as `abc`  
Expected result: the program rejects the input and asks again.

## Test 3: Out-of-Range Input
Input: `0` or `8`  
Expected result: the program rejects the input and asks for a number from 1 to 7.

## Test 4: Full Column
Input: fill the same column completely, then choose it again.  
Expected result: the program says the column is full and asks for another column.

## Test 5: Vertical Win
Input sequence: `1, 2, 1, 2, 1, 2, 1`  
Expected result: Player 1 wins vertically.

## Test 6: Horizontal Win
Input sequence: `1, 1, 2, 2, 3, 3, 4`  
Expected result: Player 1 wins horizontally.

## Test 7: Diagonal Win
Input pieces in a diagonal pattern.  
Expected result: the correct player wins diagonally.

## Test 8: Draw
Fill the board without connecting four pieces.  
Expected result: the game ends in a draw.

## Final Result
The project was tested manually through the console. The main game loop, board display, input validation, win detection, and draw detection were confirmed.
