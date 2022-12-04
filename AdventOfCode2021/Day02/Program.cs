
using Utilities;

namespace Day02;

public enum Command
{
    NotSet = 0,
    forward,
    down,
    up
}

internal static class Program
{
    private static void Main(string[] args)
    {
        // 1. Read the data in.
        ValueTuple<Command, int>[] lines = FileUtils.ReadFile<Command>("data.txt");
        
        // 2. Process the data for part 1.
        int horizontalPositionFromPart1 = 0;
        int depthFromPart1 = 0;
        for (int i = 0; i < lines.Length; i++)
        {
            switch (lines[i].Item1)
            {
                case Command.forward:
                {
                    horizontalPositionFromPart1 += lines[i].Item2;
                }
                    break;

                case Command.down:
                {
                    depthFromPart1 += lines[i].Item2;
                }
                    break;

                case Command.up:
                {
                    depthFromPart1 -= lines[i].Item2;
                }
                    break;

                case Command.NotSet:
                default:
                    throw new ArgumentOutOfRangeException();
            }            
        }
        
        // 3. Part 2
        int horizontalPositionFromPart2 = 0;
        int depthFromPart2 = 0;
        int aim = 0;
        for (int i = 0; i < lines.Length; i++)
        {
            switch (lines[i].Item1)
            {
                case Command.forward:
                {
                    int forwardMovement = lines[i].Item2;
                    horizontalPositionFromPart2 += forwardMovement;
                    depthFromPart2 += aim * forwardMovement;
                }
                    break;

                case Command.down:
                {
                    aim += lines[i].Item2;
                }
                    break;

                case Command.up:
                {
                    aim -= lines[i].Item2;
                }
                    break;

                case Command.NotSet:
                default:
                    throw new ArgumentOutOfRangeException();
            }    
        }

        Console.WriteLine("Part 1");
        Console.WriteLine("Horizontal position: " + horizontalPositionFromPart1);
        Console.WriteLine("Depth: " + depthFromPart1);
        Console.WriteLine("Horizontal position x depth: " + horizontalPositionFromPart1 * depthFromPart1);

        Console.WriteLine("Part 2");
        Console.WriteLine("Horizontal position: " + horizontalPositionFromPart2);
        Console.WriteLine("Depth: " + depthFromPart2);
        Console.WriteLine("Horizontal position x depth: " + horizontalPositionFromPart2 * depthFromPart2);
    }
}