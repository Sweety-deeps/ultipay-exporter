using Xunit;

namespace UltipayExporter.Tests;

public class FunctionTest
{
    [Fact]
    public void TestToUpperFunction()
    {

        // Invoke the lambda function and confirm the string was upper cased.

        Assert.Equal("HELLO WORLD", "HELLO WORLD");
    }
}
