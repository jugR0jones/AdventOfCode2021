namespace Day01;

internal static class Program
{
    private static void Main(string[] args)
    {
        // 1. Read in the data
        string[] tmpLines = File.ReadAllLines("data.txt");

        // tmpLines = new[]
        // {
        //     "199",
        //     "200",
        //     "208",
        //     "210",
        //     "200",
        //     "207",
        //     "240",
        //     "269",
        //     "260",
        //     "263"
        // };
        
        int[] lines = new int[tmpLines.Length];

        for (int i = 0; i < tmpLines.Length; i++)
        {
            if (!int.TryParse(tmpLines[i], out int depth))
            {
                Console.WriteLine("Invalid depth: '" + tmpLines[i] + "'.");
                return;
            }

            lines[i] = depth;
        }
        
        int numberOfTimesTheDepthIncreased = 0;

        int previousDepth = lines[0];

        // 2. Process the data for part 1.
        for (int i = 1; i < lines.Length; i++)
        {
            int depth = lines[i];
            if (depth > previousDepth)
            {
                numberOfTimesTheDepthIncreased++;
            }

            previousDepth = depth;
        }

        int numberOfTimesWindowTotalIncreased = 0;
        int previousWindowTotal = lines[0] + lines[1] + lines[2];
        // 3. Process the data for part 2
        for (int i = 1; i < lines.Length-2; i++)
        {
            int windowTotal = lines[i] + lines[i + 1] + lines[i + 2];
            if (windowTotal > previousWindowTotal)
            {
                numberOfTimesWindowTotalIncreased++;
            }

            previousWindowTotal = windowTotal;
        }
        
        Console.WriteLine("Measurements that are larger: " + numberOfTimesTheDepthIncreased);
        Console.WriteLine("Window totals that increased: " + numberOfTimesWindowTotalIncreased);
    }
}