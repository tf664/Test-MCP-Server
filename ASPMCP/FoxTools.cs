using ModelContextProtocol.Server;
using System.ComponentModel;

[McpServerToolType]
public static class FoxTools
{
    [McpServerTool, Description("Returns a random fox fact and ASCII art, inspired by the monkey MCP example.")]
    public static string FoxFact()
    {
        var fact = FoxService.GetRandomFact();
        var ascii = FoxService.GetAsciiArt();
        return $"Fox Fact: {fact}\n{ascii}";
    }

    [McpServerTool, Description("Returns all fox facts.")]
    public static string AllFoxFacts()
    {
        var facts = FoxService.GetAllFacts();
        return string.Join("\n- ", facts.Prepend("Fox Facts:"));
    }

    [McpServerTool, Description("Returns a fox fact by index.")]
    public static string FoxFactByIndex(int index)
    {
        var fact = FoxService.GetFactByIndex(index);
        return $"Fox Fact [{index}]: {fact}";
    }

    [McpServerTool, Description("Returns only the fox ASCII art.")]
    public static string FoxAsciiArt()
    {
        return FoxService.GetAsciiArt();
    }
}