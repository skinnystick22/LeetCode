using ReverseOnlyLetters;

namespace ReverseOnlyLettersTest;

public class ReverseOnlyLettersSolverTests
{
    [Theory]
    [InlineData("ab-cd", "dc-ba")]
    [InlineData("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
    [InlineData("Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!")]
    [InlineData("7_28]", "7_28]")]
    [InlineData("z<*zj", "j<*zz")]
    [InlineData("bb^aUTp", "pT^Uabb")]
    [InlineData("?6C40E", "?6E40C")]
    public void Test1(string s, string expected)
    {
        var result = ReverseOnlyLettersSolver.ReverseOnlyLetters(s);
        Assert.Equal(expected, result);
    }
}