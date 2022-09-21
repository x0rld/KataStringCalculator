using NFluent;
using Xunit;

namespace StringCalculator;

public class StringCalculator
{
    [Theory]
    [InlineData("4",4)]
    public void given_number_string_returns_number(string input, int expected)
    {
        var actual = StringCalculate.Add(input);
        
        Check.That(actual).Equals(expected);
    }

}