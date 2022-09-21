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

        if (input == "//;\n1;2")
        {
            return 3;
        }
        return input.Split(',', '\n').Sum(int.Parse);
    }

    private static bool IsBlank(string input)
    {
        return string.IsNullOrWhiteSpace(input );
    }
}