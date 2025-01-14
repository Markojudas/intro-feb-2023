﻿
namespace StringCalculator;

public class StringCalculatorTests
{
    private StringCalculator _calculator;
    public StringCalculatorTests()
    {
        _calculator = new StringCalculator();
    }

    [Fact]
    public void EmptyStringReturnsZero()
    {

        var result = _calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("138", 138)]
    public void SingleDigits(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("1,10", 11)]
    [InlineData("3,17", 20)]
    [InlineData("10,20", 30)]
    [InlineData("108, 2", 110)]
    public void DoubleDigits(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2,3", 6)]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]
    public void ArbitraryNumber(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2\n3", 6)]
    [InlineData("1\n1", 2)]
    public void MixedDelimeteres(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("//;\n1;2", 3)]
    [InlineData("//*\n1*3,1\n1", 6)]
    public void CustomDelimeteres(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("-1")]
    [InlineData("-1,2,3,-4")]
    public void NegativeNotAllowed(string numbers)
    {
        Assert.Throws<NoNegativeNumbersException>(() =>
            _calculator.Add(numbers));
    }
}
