namespace MyFirstUnitTests;

public class TestBasicMath
{
    [Fact]
    public void Add()
    {
        var result = BasicMath.Add(2, 2);
        Assert.Equal(4, result);
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(1000, 2000, 3000)]
    [InlineData(2000, 2000, 4000)]
    public void AddTheory(int x, int y, int expectedResult)
    {
        var result = BasicMath.Add(x, y);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(1, 20, 21)]
    public void TestAddition(int x, int y, int z)
    {
        var result = BasicMath.Add(x, y);
        Assert.Equal(result, z);
    }
}
