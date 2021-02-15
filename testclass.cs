using Xunit;
using Labstats;

public class testclass
{
    [Fact]
    public void getBagsTest()
    {
        Assert.Equal(6, Program.getBags("5"));
        Assert.InRange(42, Program.getBags("0"), Program.getBags("40"));
    }

    [Theory]
    [InlineData(3, 5)]
    [InlineData(1, 0)]
    [InlineData(5, -10)]
    public void differenceTest(int a, int b)
    {
        int c = a - b;
        if (c < 0)
        {
            c = c * -1;
            Assert.Equal(c, Program.difference(a,b));
        }
        else
        {
            Assert.Equal(c, Program.difference(a,b));
        }
    }

}