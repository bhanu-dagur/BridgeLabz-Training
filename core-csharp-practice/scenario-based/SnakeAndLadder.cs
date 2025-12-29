// Start Game
// ↓
// Take Players
// ↓
// Initialize positions
// ↓
// while (no winner)
//    foreach player
//       roll dice
//       calculate new position
//       if >100 → skip
//       apply snake/ladder
//       display details
//       if position == 100 → win & break
// End
using System;

class SnakeAndLadder
{
    static Random random = new Random();

    static void Main()
    {
        Console.Write("Enter number of players (2 to 4): ");
        int playerCount = int.Parse(Console.ReadLine());

        if (playerCount < 2 || playerCount > 4)
        {
            Console.WriteLine("Invalid number of players.");
            return;
        }

        string[] players = new string[playerCount];
        int[] positions = new int[playerCount];

        for (int i = 0; i < playerCount; i++)
        {
            Console.Write("Enter name of Player "+(i + 1)+": ");
            players[i] = Console.ReadLine();
            positions[i] = 0;
        }

        //  Multi-Dimensional Array (Snakes & Ladders)
        int[,] snakesAndLadders =
        {
            {4, 14},
            {9, 31},
            {17, 7},
            {54, 34},
            {62, 81},
            {87, 24},
            {98, 79}
        };

        bool gameOver = false;

        while (!gameOver)
        {
            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine("\n "+players[i]+" 's Turn");
                int dice = RollDice();
                Console.WriteLine("Dice Rolled: "+dice);

                int oldPosition = positions[i];
                int newPosition = oldPosition + dice;

                // Skip turn if > 100
                if (newPosition > 100)
                {
                    Console.WriteLine("Move skipped (exceeds 100)");
                    continue;
                }

                positions[i] = newPosition;
                Console.WriteLine("Moved from "+oldPosition+" to "  +newPosition);

                // Apply Snake or Ladder
                positions[i] = ApplySnakeOrLadder(positions[i], snakesAndLadders);

                // Win Check
                if (CheckWin(positions[i]))
                {
                    Console.WriteLine("\n" + players[i]+" WINS THE GAME!");
                    gameOver = true;
                    break;
                }
            }
        }
    }

    static int RollDice()
    {
        return random.Next(1, 7);
    }

    static int ApplySnakeOrLadder(int position, int[,] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board[i, 0] == position)
            {
                string message = board[i, 1] > position ? " Ladder!" : "Snake!";
                Console.WriteLine(message+" Move to "+board[i, 1]);
                return board[i, 1];
            }
        }
        return position;
    }

    static bool CheckWin(int position)
    {
        return position == 100 ? true : false; // ternary operator
    }
}
