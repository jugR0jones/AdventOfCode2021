namespace Day01;

internal static class Program
{
    private static void Main(string[] args)
    {
        // 1. Read in the data
        string[] lines = File.ReadAllLines("data.txt");

        int numberOfTimesTheDepthIncreased = 0;

        if (!int.TryParse(lines[0], out int previousDepth))
        {
            Console.WriteLine("Invalid depth.");
            return;
        }
        
        // 2. Process the data
        for (int i = 1; i < lines.Length; i++)
        {
            if (!int.TryParse(lines[i], out int depth))
            {
                Console.WriteLine("Invalid depth.");
                return;
            }
            
            if (depth > previousDepth)
            {
                numberOfTimesTheDepthIncreased++;
            }

            previousDepth = depth;
        }
        
        Console.WriteLine("Measurements that are larger: " + numberOfTimesTheDepthIncreased);
    }
}