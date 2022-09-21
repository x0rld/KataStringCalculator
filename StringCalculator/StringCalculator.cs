using NFluent;
using Xunit;

namespace StringCalculator;

public class StringCalculateTest
{
    [Theory]
    [InlineData("4",4)]
    public void given_one_number_string_returns_number(string input, int expected)
    {
        var actual = StringCalculate.Add(input);
        
        Check.That(actual).Equals(expected);
    }
    
    [Theory]
    [InlineData("1,2",3)]
    [InlineData("3,4",7)]
    [InlineData("3,4,3",10)]
    public void any_numbers_string_returns_sum_of_numbers(string input, int expected)
    {
        var actual = StringCalculate.Add(input);

        Check.That(actual).Equals(expected);
    }

    [Theory]
    [InlineData("3\n4", 7)]
    [InlineData("3,4\n3", 10)]
    public void any_number_either_comma_or_newline_separator_returns_sum_of_numbers(string input, int expected)
    {        
        var actual = StringCalculate.Add(input);
        Check.That(actual).Equals(expected);
    }

    [Theory]
    [InlineData("//;\n1;2", 3)]
    public void any_number_with_custom_separator_returns_sum_of_numbers(string input, int expected)
    {
        var actual = StringCalculate.Add(input);
        Check.That(actual).Equals(expected);
    }
}