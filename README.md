# game-10003-voigt-rowan-a1-chess-puzzles
A few chess puzzles I recreated in the terminal.
They are designed to test a users ability to solve chess puzzles in 1 move.

# Instructions
Below are some quick instructions which are also visible in-program.

## Piece identification.
Q = Queen, K = King, R = Rook, N = Knight, B = Bishop, P = Pawn.
White pieces are capital letters, black pieces are lowercase.
White: Q, K, R, N, B, P. Black: q, k, r, n, b, p.
Squares marked with - are squares with no active piece on them.

## Moving a piece.
Move a piece using it's letter, followed by the X and Y coordinates.
Example: B23 = White Bishop moves to X position 2 and Y position 3. r57 = Black Rook moves to X position 5 and Y position 7.

## Checkmating
To checkmate, you must move a piece in a way that it targets the opposing team's King.
The King must not be able to move to other positions without being targeted by other pieces.
If the King is in danger, and has no safe squares to move to, it is checkmate.