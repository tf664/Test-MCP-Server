- Usage in VSCode Github Copilot
    
    Inside this workspace folder, also create `mcp.json` . Which tells Github Copilot that inside this repo this MCP server will be used. One can also stop and restart the server in `mcp.json` manually

- Usage in Claude Desktop
    Inside the claude_desktop_config.json add: (THIS TOOK A LOT OF DEBUGGING)
    ```json
    "aspmcp": {
      "type": "stdio",
      "command": "dotnet",
      "args": [
          "run",
          "--project",
          "C:\\Users\\til.feldkamp\\Desktop\\ASP MCPYT\\ASPMCP\\ASPMCP.csproj"
      ]
    }
    ```
The weird thing: as far as the current knowledge goes, the MCP servers are starting, when the LLM is started. The server do not to be started seperately. Moreover, when e.g. starting the server via mcp.json and then trying to use it in Claude Desktop one runs into an error