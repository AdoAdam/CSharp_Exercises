using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktioner
{
    public class Snake
    {
        static int width = 28;
        static int height = 14;
        static char[,] grid;

        static List<Vector2Int> positions = new List<Vector2Int>();
        static Vector2Int startPosition = new Vector2Int(width / 2, height / 2);
        static Vector2Int currentPosition = new Vector2Int(width / 2, height / 2);
        static Vector2Int applePosition;

        static int snakeLength = 1;
        static int moves = 0;
        static int snakeSpeed = 500;

        static bool isAlive = true;

        public static void Play()
        {
            Console.Clear();
            Console.CursorVisible = false;
            ResetSnake();
            grid = GetGridArray(width, height);
            DrawBoxFromArray(grid);
            applePosition = SetRandomApplePosition(grid);
            Move();

        }

        static void Move()
        {
            Console.SetCursorPosition(startPosition.x, startPosition.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("@");

            positions.Add(startPosition);

            while (isAlive)
            {
                ConsoleKey lastKeyPressed = Console.ReadKey().Key;

                switch (lastKeyPressed)
                {
                    case ConsoleKey.LeftArrow:
                        MoveInDirection(lastKeyPressed, -1);
                        break;
                    case ConsoleKey.RightArrow:
                        MoveInDirection(lastKeyPressed, 1);
                        break;
                    case ConsoleKey.UpArrow:
                        MoveInDirection(lastKeyPressed, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        MoveInDirection(lastKeyPressed, 1);
                        break;
                    case ConsoleKey.Q:
                        isAlive = false;
                        break;
                }
            }
        }

        static void MoveInDirection(ConsoleKey lastKeyPressed, int direction)
        {
            while (!Console.KeyAvailable)
            {
                moves++;
                
                if (lastKeyPressed == ConsoleKey.LeftArrow || lastKeyPressed == ConsoleKey.RightArrow)
                {
                    currentPosition.x += direction;
                }
                else if (lastKeyPressed == ConsoleKey.UpArrow || lastKeyPressed == ConsoleKey.DownArrow)
                {
                    currentPosition.y += direction;
                }

                if (IsOutsideBounds())
                {
                    isAlive = false;
                    break;
                }

                Vector2Int newPos = new Vector2Int(currentPosition.x, currentPosition.y);
                positions.Add(newPos);
                DrawNextSnakePosition(newPos);
                RemoveLast();
                CheckIfPosIsApplePos(newPos, snakeLength, grid);
                Thread.Sleep(snakeSpeed);
            }
        }

        static void DrawNextSnakePosition(Vector2Int newPos)
        {
            Console.SetCursorPosition(newPos.x, newPos.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("@");
        }

        static bool IsOutsideBounds()
        {
            if (currentPosition.y > height - 2 || currentPosition.y < 0 || currentPosition.x > width - 2 || currentPosition.x < 1)
                return true;
            else
                return false;
        }

        static void RemoveLast()
        {
            if (moves >= snakeLength)
            {
                Console.SetCursorPosition(positions[0].x, positions[0].y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("-");
                positions.Remove(positions[0]);
 
            }
        }
        static Vector2Int SetRandomApplePosition(char[,] grid)
        {
            Random random = new Random();
            int randomX = random.Next(2, grid.GetLength(0) - 2);
            int randomY = random.Next(2, grid.GetLength(1) - 2);

            if (grid[randomX, randomY] != '#')
            {
                Console.SetCursorPosition(randomX, randomY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("*");
            }
            else
            {
                SetRandomApplePosition(grid);
            }
            Console.ResetColor();
            return new Vector2Int(randomX, randomY);
        }

        static void CheckIfPosIsApplePos(Vector2Int pos, int snakeLength, char[,] grid)
        {
            if (pos.x == applePosition.x && pos.y == applePosition.y)
            {
                positions.Add(applePosition);
                applePosition = SetRandomApplePosition(grid);
                snakeSpeed -= 20;
                snakeLength++;
            }
        }

        static void ResetSnake()
        {
            moves = 0;
            snakeLength = 1;
            currentPosition = new Vector2Int(width / 2, height / 2);
            positions.Clear();
            isAlive = true;
        }

        static char[,] GetGridArray(int width, int height)
        {
            char[,] grid = new char[width, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (y == 0 || y == height - 1 || x == 0 || x == width - 1)
                    {
                        grid[x, y] = '#';
                    }
                    else
                    {
                        grid[x, y] = '-';
                    }
                }
            }
            return grid;
        }

        static void DrawBoxFromArray(char[,] grid)
        {
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                for (int x = 0; x < grid.GetLength(0); x++)
                {
                    Console.Write(grid[x, y]);
                }
                Console.WriteLine();
            }
        }
    }

    public class Vector2Int
    {
        public int x;
        public int y;

        public Vector2Int(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

    }
}
