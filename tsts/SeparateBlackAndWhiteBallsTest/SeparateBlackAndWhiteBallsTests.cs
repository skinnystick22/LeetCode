using SeparateBlackAndWhiteBalls;
using Xunit;

namespace SeparateBlackAndWhiteBallsTest;

public class SeparateBlackAndWhiteBallsTests
{
    [Fact]
    public void Test_AllZeros_ReturnsZero()
    {
        const string input = "0000";
        const long expected = 0;
        var result = SeparateBlackAndWhiteBallsSolver.MinimumSteps(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_AllOnes_ReturnsZero()
    {
        const string input = "1111";
        const long expected = 0;
        var result = SeparateBlackAndWhiteBallsSolver.MinimumSteps(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_AlternatingPattern()
    {
        const string input = "0101";
        const long expected = 1;
        var result = SeparateBlackAndWhiteBallsSolver.MinimumSteps(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_ReverseAlternatingPattern()
    {
        const string input = "1010";
        const long expected = 3;
        var result = SeparateBlackAndWhiteBallsSolver.MinimumSteps(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_MixedPattern()
    {
        const string input = "010101";
        const long expected = 3;
        var result = SeparateBlackAndWhiteBallsSolver.MinimumSteps(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_SingleZero()
    {
        const string input = "0";
        const long expected = 0;
        var result = SeparateBlackAndWhiteBallsSolver.MinimumSteps(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_SingleOne()
    {
        const string input = "1";
        const long expected = 0;
        var result = SeparateBlackAndWhiteBallsSolver.MinimumSteps(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_EmptyString()
    {
        const string input = "";
        const long expected = 0;
        var result = SeparateBlackAndWhiteBallsSolver.MinimumSteps(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LongString()
    {
        const string input = "000011110000";
        const long expected = 16;
        var result = SeparateBlackAndWhiteBallsSolver.MinimumSteps(input);
        Assert.Equal(expected, result);
    }
}