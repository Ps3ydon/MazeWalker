using System;

namespace MazeWalker
{
    public enum Direction
    {
        up = 0,
        left = 1,
        down = 2,
        right = 3
    }

    public static class Input
    {
        public static Direction getInput()
        {
            ConsoleKey input = Console.ReadKey().Key;

            switch (input)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    return Direction.up;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    return Direction.left;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    return Direction.down;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    return Direction.right;
            }

            return Direction.up;
        }
    }
}
