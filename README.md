# Fox Test MCP Server

This repo includes a MCP server regarding fox facts.
It was created a part of a research task regarding MCP server in an enterprise CAQ-software.

## Usage

- Usage in VSCode Github Copilot
    
    Inside this workspace folder, also create `mcp.json` . Which tells Github Copilot that inside this repo this MCP server will be used. One can also stop and restart the server in `mcp.json` manually

- Usage in Claude Desktop
    Inside the claude_desktop_config.json add:
    ```json
    "foxfacts": {
      "type": "stdio",
      "command": "dotnet",
      "args": [
          "run",
          "--project",
          "C:\\Users\\til.feldkamp\\Desktop\\ASP MCPYT\\ASPMCP\\ASPMCP.csproj"
      ]
    }
    ```
