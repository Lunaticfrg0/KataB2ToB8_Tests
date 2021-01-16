using Xunit; 
using Kata__6;
public class testClass
{
    [Fact]
    public void TestCase1()
    {
        Assert.Equal("71", Program.ConvertB2ToB8("111001"));
    }
}