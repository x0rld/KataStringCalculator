﻿namespace StringCalculator;

public class StringCalculate
{
    public static int Add(string input)
    {
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