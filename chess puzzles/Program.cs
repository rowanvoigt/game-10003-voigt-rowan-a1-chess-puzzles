// Ask the player what difficulty they want to choose.
Console.WriteLine($"Are you ready to solve some chess puzzles?");
Console.WriteLine($"Select a difficulty!");
Console.WriteLine($"[Beginner] [Easy] [Medium] [Hard]");
// Inform the player that they can view the instructions.
Console.WriteLine($"Type [Instructions] for a quick introduction on how to play! Recommended for everyone.");

string difficulty = (Console.ReadLine());
// Show them the puzzle below if they choose beginner difficulty.
if (difficulty == $"Beginner")
{
    Console.Clear();
    Console.WriteLine("8 | -  -  -  -  -  -  -  -");
    Console.WriteLine("7 | K  -  k  -  -  q  -  -");
    Console.WriteLine("6 | -  -  p  -  -  -  -  -");
    Console.WriteLine("5 | -  -  -  -  -  -  -  -");
    Console.WriteLine("4 | -  -  -  -  -  -  -  -");
    Console.WriteLine("3 | -  -  -  -  -  -  -  -");
    Console.WriteLine("2 | -  -  -  -  -  -  -  -");
    Console.WriteLine("1 | -  -  -  -  -  -  -  -");
    Console.WriteLine("  -------------------------");
    Console.WriteLine("0   1  2  3  4  5  6  7  8");
    Console.WriteLine();
    Console.WriteLine("Black to move, checkmate in 1.");
    Console.WriteLine("Input move below.");
    string move = (Console.ReadLine());
    // Check if their move is the correct one. If it is correct, update the board with the correct move and say "Checkmate!"
    if (move == "q12")
    {
        Console.Clear();
        Console.WriteLine("8 | -  -  -  -  -  -  -  -");
        Console.WriteLine("7 | K  -  k  -  -  -  -  -");
        Console.WriteLine("6 | -  -  p  -  -  -  -  -");
        Console.WriteLine("5 | -  -  -  -  -  -  -  -");
        Console.WriteLine("4 | -  -  -  -  -  -  -  -");
        Console.WriteLine("3 | -  -  -  -  -  -  -  -");
        Console.WriteLine("2 | q  -  -  -  -  -  -  -");
        Console.WriteLine("1 | -  -  -  -  -  -  -  -");
        Console.WriteLine("  -------------------------");
        Console.WriteLine("0   1  2  3  4  5  6  7  8");
        Console.WriteLine();
        Console.WriteLine("Black Queen moves to X1, Y2! Checkmate!");
    }
    // If they make the wrong move, put this below.
    else
        Console.WriteLine("Good try, but that is not correct.");
}
// Put this below if the difficulty they choose is hard. The base ode for this is the same for all the difficulties.
else if (difficulty == $"Hard")
{
    Console.Clear();
    Console.WriteLine("8 | -  B  b  -  -  -  B  N");
    Console.WriteLine("7 | R  -  -  P  k  -  -  r");
    Console.WriteLine("6 | -  Q  -  -  -  -  -  B");
    Console.WriteLine("5 | -  -  -  -  q  -  -  R");
    Console.WriteLine("4 | -  -  b  N  -  -  -  -");
    Console.WriteLine("3 | -  -  -  -  Q  -  B  K");
    Console.WriteLine("2 | -  p  -  -  -  -  -  -");
    Console.WriteLine("1 | -  b  q  -  R  -  r  b");
    Console.WriteLine("  -------------------------");
    Console.WriteLine("0   1  2  3  4  5  6  7  8");
    Console.WriteLine();
    Console.WriteLine("White to move, checkmate in 1.");
    Console.WriteLine("Input move below.");
    string move = (Console.ReadLine());
    // Once again, check if they found the right move. If they did, update the board again. Same base code for all the other difficulties.
    if (move == "Q13")
    {
        Console.Clear();
        Console.WriteLine("8 | -  B  b  -  -  -  B  N");
        Console.WriteLine("7 | R  -  -  P  k  -  -  r");
        Console.WriteLine("6 | -  Q  -  -  -  -  -  B");
        Console.WriteLine("5 | -  -  -  -  q  -  -  R");
        Console.WriteLine("4 | -  -  b  N  -  -  -  -");
        Console.WriteLine("3 | Q  -  -  -  -  -  B  K");
        Console.WriteLine("2 | -  p  -  -  -  -  -  -");
        Console.WriteLine("1 | -  b  q  -  R  -  r  b");
        Console.WriteLine("  -------------------------");
        Console.WriteLine("0   1  2  3  4  5  6  7  8");
        Console.WriteLine();
        Console.WriteLine("White Queen moves to X1, Y3! Checkmate!");
    }
    // More code for if they get the wrong answer. Another thing that's the same for all difficulties.
    else
        Console.WriteLine("Good try, but that is not correct.");
}
else if (difficulty == $"Medium")
{
    Console.Clear();
    Console.WriteLine("8 | -  k  -  -  -  -  -  r");
    Console.WriteLine("7 | p  p  -  Q  -  -  p  -");
    Console.WriteLine("6 | -  -  -  b  -  -  -  p");
    Console.WriteLine("5 | -  -  -  B  P  -  -  -");
    Console.WriteLine("4 | -  -  -  p  -  -  -  -");
    Console.WriteLine("3 | -  -  -  -  -  -  -  P");
    Console.WriteLine("2 | P  -  -  N  -  P  P  -");
    Console.WriteLine("1 | R  -  -  -  -  -  K  -");
    Console.WriteLine("  -------------------------");
    Console.WriteLine("0   1  2  3  4  5  6  7  8");
    Console.WriteLine();
    Console.WriteLine("White to move, checkmate in 1.");
    Console.WriteLine("Input move below.");
    string move = (Console.ReadLine());
    if (move == "Q27")
    {
        Console.Clear();
        Console.WriteLine("8 | -  k  -  -  -  -  -  r");
        Console.WriteLine("7 | p  Q  -  -  -  -  p  -");
        Console.WriteLine("6 | -  -  -  b  -  -  -  p");
        Console.WriteLine("5 | -  -  -  B  P  -  -  -");
        Console.WriteLine("4 | -  -  -  p  -  -  -  -");
        Console.WriteLine("3 | -  -  -  -  -  -  -  P");
        Console.WriteLine("2 | P  -  -  N  -  P  P  -");
        Console.WriteLine("1 | R  -  -  -  -  -  K  -");
        Console.WriteLine("  -------------------------");
        Console.WriteLine("0   1  2  3  4  5  6  7  8");
        Console.WriteLine();
        Console.WriteLine("White queen moves to X2, Y7! Checkmate!");
    }
    else
        Console.WriteLine("Good try, but that is not correct.");
}
else if (difficulty == $"Easy")
{
    Console.Clear();
    Console.WriteLine("8 | k  r  -  -  -  -  -  -");
    Console.WriteLine("7 | -  p  -  -  -  -  -  -");
    Console.WriteLine("6 | p  -  -  -  -  -  -  -");
    Console.WriteLine("5 | -  -  -  -  b  -  -  -");
    Console.WriteLine("4 | -  -  -  -  -  -  -  -");
    Console.WriteLine("3 | -  -  -  -  -  -  -  -");
    Console.WriteLine("2 | -  P  -  -  -  -  B  P");
    Console.WriteLine("1 | R  -  -  -  -  -  -  K");
    Console.WriteLine("  -------------------------");
    Console.WriteLine("0   1  2  3  4  5  6  7  8");
    Console.WriteLine();
    Console.WriteLine("White to move, checkmate in 1.");
    Console.WriteLine("Input move below.");
    string move = (Console.ReadLine());
    if (move == "R16")
    {
        Console.Clear();
        Console.WriteLine("8 | k  r  -  -  -  -  -  -");
        Console.WriteLine("7 | -  p  -  -  -  -  -  -");
        Console.WriteLine("6 | R  -  -  -  -  -  -  -");
        Console.WriteLine("5 | -  -  -  -  b  -  -  -");
        Console.WriteLine("4 | -  -  -  -  -  -  -  -");
        Console.WriteLine("3 | -  -  -  -  -  -  -  -");
        Console.WriteLine("2 | -  P  -  -  -  -  B  P");
        Console.WriteLine("1 | -  -  -  -  -  -  -  K");
        Console.WriteLine("  -------------------------");
        Console.WriteLine("0   1  2  3  4  5  6  7  8");
        Console.WriteLine();
        Console.WriteLine("White Rook moves to X1, Y6! Checkmate!");
    }
    else
        Console.WriteLine("Good try, but that is not correct.");
}
// The code below is what gives the player their instructions on how to play.
else if (difficulty == $"Instructions")
{
    // The Console.Clear(); line helps keep it clean for the user, so that they do not have a whole bunch of lines of code on their screen.
    Console.Clear();
    Console.WriteLine($"Q = Queen, K = King, R = Rook, N = Knight, B = Bishop, P = Pawn.");
    Console.WriteLine($"White pieces are capital letters, black pieces are lowercase.");
    Console.WriteLine($"White: Q, K, R, N, B, P. Black: q, k, r, n, b, p.");
    Console.WriteLine($"Squares marked with - are squares with no active piece on them.");
    Console.WriteLine($"Move a piece using it's letter, followed by the X and Y coordinates.");
    Console.WriteLine($"Example: B23 = White Bishop moves to X position 2 and Y position 3.");
}
else
    Console.WriteLine("That is not one of the options.");
