namespace Utilities;

public static class FileUtils
{
    public static int[] ReadFile(in string path)
    {
        try
        {
            string[] tmpLines = File.ReadAllLines(path);

            int[] lines = new int[tmpLines.Length];

            for (int i = 0; i < tmpLines.Length; i++)
            {
                if (!int.TryParse(tmpLines[i], out int depth))
                {
                    Console.WriteLine("Invalid depth: '" + tmpLines[i] + "'.");

                    return null;
                }

                lines[i] = depth;
            }

            return lines;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);

            return null;
        }
    }
    
    public static ValueTuple<TEnum, int>[] ReadFile<TEnum>(in string path) where TEnum : struct, System.Enum
    {
        char[] characterToSplitOn = {
            ' '
        };

        try
        {
            string[] tmpLines = File.ReadAllLines(path);

            ValueTuple<TEnum, int>[] lines = new ValueTuple<TEnum, int>[tmpLines.Length];

            for (int i = 0; i < tmpLines.Length; i++)
            {
                string[] splitLine = tmpLines[i].Split(characterToSplitOn);

                //  TEnum value = (TEnum) Enum.Parse(typeof(TEnum), splitLine[0]);

                if (!Enum.TryParse<TEnum>(splitLine[0], out TEnum enumValue))
                {
                    Console.WriteLine("Could not convert '" + splitLine[0] + "' to an ENUM value.");

                    return null;
                }
                
                if (!int.TryParse(splitLine[1], out int count))
                {
                    Console.WriteLine("Invalid count: '" + splitLine[1] + "'.");

                    return null;
                }

                lines[i] = new ValueTuple<TEnum, int>(enumValue, count);
            }

            return lines;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);

            return null;
        }
    }
}