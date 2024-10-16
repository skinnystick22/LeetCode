using ReverseWordsInStringIII;

namespace ReverseWordsInStringIIITest;

public class ReverseWordsInStringIIISolverTests
{
    [Theory]
    [InlineData("It's a great day", "s'tI a taerg yad")]
    [InlineData( "Mr Ding", "rM gniD")]
    public void Test_ReversedWordStringMatchedExpected(string s, string expected)
    {
        var result = ReverseWordsInStringIIISolver.ReverseWords(s);
        Assert.Equal(expected, result);
    }
}