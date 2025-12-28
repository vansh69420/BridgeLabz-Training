using System;

class SnakeAndLadder
{
    static Random random = new Random();

    // Snake start and end positions
    static int[] snakeStart = { 99, 70, 52, 25 };
    static int[] snakeEnd   = { 54, 55, 42, 2 };

    // Ladder start and end positions
    static int[] ladderStart = { 6, 11, 46, 60 };
    static int[] ladderEnd   = { 25, 40, 90, 85 };

    static void Main()
    {
        Console.WriteLine("🎲 Welcome to Snake & Ladder Game 🎲");

        int playerCount;
        do
        {
            Console.Write("Enter number of players (2 to 4): ");
            playerCount = Convert.ToInt32(Console.ReadLine());
        } while (playerCount < 2 || playerCount > 4);

        string[] players = new string[playerCount];
        int[] positions = new int[playerCount];

        // Input player names
        for (int i = 0; i < playerCount; i++)
        {
            Console.Write($"Enter name of Player {i + 1}: ");
            players[i] = Console.ReadLine();
            positions[i] = 0;
        }

        bool gameWon = false;

        // Main Game Loop
        while (!gameWon)
        {
            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine($"\n👉 {players[i]}'s turn. Press Enter to roll dice");
                Console.ReadLine();

                int dice = RollDice();
                Console.WriteLine($"🎲 Dice: {dice}");

                int oldPosition = positions[i];
                int newPosition = oldPosition + dice;

                if (newPosition > 100)
                {
                    Console.WriteLine("⚠ Move exceeds 100. Turn skipped.");
                    continue;
                }

                positions[i] = newPosition;

                // Apply snake or ladder
                positions[i] = ApplySnakeOrLadder(positions[i]);

                Console.WriteLine($"{players[i]} moved from {oldPosition} → {positions[i]}");

                if (CheckWin(positions[i]))
                {
                    Console.WriteLine($"\n🏆 {players[i]} WINS THE GAME! 🏆");
                    gameWon = true;
                    break;
                }
            }
        }

        Console.WriteLine("\nGame Over. Thank you for playing!");
    }

    // Roll dice (1 to 6)
    static int RollDice()
    {
        return random.Next(1, 7);
    }

    // Apply snake or ladder using arrays
    static int ApplySnakeOrLadder(int position)
    {
        // Check snakes
        for (int i = 0; i < snakeStart.Length; i++)
        {
            if (position == snakeStart[i])
            {
                Console.WriteLine($"🐍 Snake bite! Down to {snakeEnd[i]}");
                return snakeEnd[i];
            }
        }

        // Check ladders
        for (int i = 0; i < ladderStart.Length; i++)
        {
            if (position == ladderStart[i])
            {
                Console.WriteLine($"🪜 Ladder found! Up to {ladderEnd[i]}");
                return ladderEnd[i];
            }
        }

        return position;
    }

    // Check win condition
    static bool CheckWin(int position)
    {
        return position == 100 ? true : false;
    }
}
