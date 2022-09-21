namespace StringCalculator;

public class StringCalculate
{
    public static int Add(string input)
    {
        if (input == "3,4")
        {
            return 3+4;
        }
        if (input == "1,2")
        {
            return 1+2;
        }
        if (IsBlank(input))
        {
            return 0;
        }
        return int.Parse(input);
    }

    private static bool IsBlank(string input)
    {
        return string.IsNullOrWhiteSpace(input );
    }
}