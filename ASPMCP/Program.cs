using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ModelContextProtocol.Server;
using System.ComponentModel;

var builder = Host.CreateApplicationBuilder(args);
builder.Logging.AddConsole(consoleLogOptions =>
{
    // Configure all logs to go to stderr
    consoleLogOptions.LogToStandardErrorThreshold = LogLevel.Trace;
});
builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    .WithToolsFromAssembly();
await builder.Build().RunAsync();

[McpServerToolType]
public static class ASPTools
{
    [McpServerTool, Description("Echoes the message back to the client.")]
    public static string Echo(string message) => $"AHHHHHHH {message}";

    [McpServerTool, Description("Get the current day of the week")]
    public static string GetDayOfWeek()
    {
        var today = DateTime.Now.ToString("dddd");
        return $"Today is the day: {today}.";
    }
}