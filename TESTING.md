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

## Test 4: Vertical Win
Input sequence: `1, 2, 1, 2, 1, 2, 1`  
Expected result: Player 1 wins vertically.

## Test 5: Horizontal Win
Input sequence: `1, 1, 2, 2, 3, 3, 4`  
Expected result: Player 1 wins horizontally.

## Final Result
The game was tested manually in Visual Studio. The board display, player input, turn switching, win detection, and replay prompt worked correctly.
