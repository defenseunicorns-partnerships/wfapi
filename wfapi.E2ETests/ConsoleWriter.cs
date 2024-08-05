using Xunit.Abstractions;

namespace wfapi.E2ETests;

public class ConsoleWriter : StringWriter
{
    private ITestOutputHelper output;

    public ConsoleWriter(ITestOutputHelper output)
    {
        this.output = output;
    }

    public override void WriteLine(string? m)
    {
        output.WriteLine(m);
    }
}
