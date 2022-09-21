using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculator;

public class StringCalculate
{
    public static int Add(string input)
    {
        if (IsBlank(input))
        {
            return 0;
        }
        
        const string separatorDeclarator = "//";
        if (input.StartsWith(separatorDeclarator))
        {
            var separatorSubstring = input.Substring(2, 1);
            return   input.Substring(4).Split(separatorSubstring, '\n').Sum(int.Parse);
        }
        return input.Split(',', '\n').Sum(int.Parse);
    }

    private static bool IsBlank(string input)
    {
        return string.IsNullOrWhiteSpace(input );
    }
}