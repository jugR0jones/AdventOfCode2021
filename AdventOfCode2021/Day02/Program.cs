
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
//        string[] tmpLines = File.ReadAllLines("data.txt");

         ValueTuple<Command, int>[] lines = FileUtils.ReadFile<Command>("data.txt");
        
        // 2. Process the data for part 1.
        int horizontalPosition = 0;
        int depth = 0;
        for (int i = 0; i < lines.Length; i++)
        {
            switch (lines[i].Item1)
            {
                case Command.forward:
                {
                    horizontalPosition += lines[i].Item2;
                }
                    break;

                case Command.down:
                {
                    depth += lines[i].Item2;
                }
                    break;

                case Command.up:
                {
                    depth -= lines[i].Item2;
                }
                    break;

                case Command.NotSet:
                default:
                    throw new ArgumentOutOfRangeException();
            }            
        }
        
        Console.WriteLine("Horizontal position: " + horizontalPosition);
        Console.WriteLine("Depth: " + depth);
        Console.WriteLine("Horizontal position x depth: " + horizontalPosition * depth);
    }
}