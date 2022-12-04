
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
        for (int i = 0; i < lines.Length; i++)
        {
            
        }
    }
}