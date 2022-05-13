namespace MyFirstUnitTests;

public class TestNumbersReader
{
    // Unit test for the reader
    [Fact]
    public async Task TestReadNumbers()
    {
        var reader = new NumbersReader();
        Assert.Equal(new[] { 1, 2, 3, 4, 5 }, await reader.ReadNumbers());
    }

}
