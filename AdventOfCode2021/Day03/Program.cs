namespace Day03;

internal static class Program
{
    private static void Main(string[] args)
    {
        // 1. Read in the data
        string[] lines = File.ReadAllLines("data.txt");
        
        // lines = new []
        // {
        //     "00100",
        //     "11110",
        //     "10110",
        //     "10111",
        //     "10101",
        //     "01111",
        //     "00111",
        //     "11100",
        //     "10000",
        //     "11001",
        //     "00010",
        //     "01010",
        // };

        // 2. Part 1
        
        // Determine the most popular number in each column.
        int numberOfDiagnosticReadings = lines.Length;
        int numberOfDiagnosticReadingsToBeConsideredCommon = numberOfDiagnosticReadings / 2;
        int widthOfTheBinaryNumber = lines[0].Length;
        string gammaRateStr = string.Empty;
        string epsilonRateStr = string.Empty;

        for (int i = 0; i < widthOfTheBinaryNumber; i++)
        {
            int occurrenceOfOnes = 0;
            foreach (string line in lines)
            {
                if (line[i] == '1')
                {
                    occurrenceOfOnes++;
                }
            }

            if (occurrenceOfOnes >= numberOfDiagnosticReadingsToBeConsideredCommon)
            {
                gammaRateStr += '1';
                epsilonRateStr += '0';
            }
            else
            {
                gammaRateStr += '0';
                epsilonRateStr += '1';
            }
        }
        
        Console.WriteLine("Gamma Rate: " + gammaRateStr);
        Console.WriteLine("Epsilon Rate: " + epsilonRateStr);
        
        int gammaRateInPart1 = Convert.ToInt32(gammaRateStr, 2);
        int epsilonRateInPart1 = Convert.ToInt32(epsilonRateStr, 2);
        
        Console.WriteLine("Power consumption: " + gammaRateInPart1 * epsilonRateInPart1);
    }
}