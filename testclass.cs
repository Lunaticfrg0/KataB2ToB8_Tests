using Xunit; 
using Kata__6;
public class testClass
{
    [Fact]
    public void TestCase1()
    {
        Assert.Equal("71", Program.ConvertB2ToB8("111001"));
    }
     [Fact]
    public void TestCase2()
    {
        Assert.Equal("52", Program.ConvertB2ToB8("101010"));
    }
     [Fact]
    public void TestCase3()
    {
        Assert.Equal("35", Program.ConvertB2ToB8("11101"));
    }
}