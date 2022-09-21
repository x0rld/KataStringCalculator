using System.Linq;

namespace StringCalculator;

public class StringCalculate
{
    public static int Add(string input)
    {
        if (IsBlank(input))
        {
            return 0;
        }
        
        return input.Split(",").Sum(int.Parse);
    }

    private static bool IsBlank(string input)
    {
        return string.IsNullOrWhiteSpace(input );
    }
}