using System.Collections.Generic;
using System.Linq;

namespace MyFirstUnitTests;

public class TestBasicStatistics
{
    private class TestReader : IReaderBase
    {
        // Simulate the reader
        public Task<IEnumerable<int>> ReadNumbers()
            // Mock object
            => Task.FromResult(new[] { 1, 2 }.AsEnumerable());
    }

    [Fact] //Unit test for the sum-reader-method
    public async Task SumValueFromReader()
    {
        var statistics = new BasicStatistics(new TestReader());
        var result = await statistics.SumValueFromReader();
        Assert.Equal(3, result);
    }

    [Fact] //Integration test the reader and sum-method
    public async Task SumValueFromReader2()
    {
        var statistics = new BasicStatistics(new NumbersReader());
        var result = await statistics.SumValueFromReader();
        Assert.Equal(15, result);
    }
}
 