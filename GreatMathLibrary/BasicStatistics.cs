namespace GreatMathLibrary;

public class BasicStatistics
{
    /* We use the interface to decouple tasks / functions to 
      enable single unit tests instead of integration tests */
    private readonly IReaderBase reader;

    public BasicStatistics(IReaderBase reader)
    {
        this.reader = reader;
    }

    public async Task<int> SumValueFromReader()
    {
        var numbers = await reader.ReadNumbers();
        return numbers.Sum();
    }
}
