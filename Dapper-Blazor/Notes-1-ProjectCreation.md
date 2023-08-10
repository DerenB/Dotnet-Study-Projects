# CLI Creation Lines

- Solution: `dotnet new sln`
- Empty Blazor App: `dotnet new blazorserver-empty -f net7.0`
- Class Library: `dotnet new classlib -f net7.0`
  - Delete "Class1.cs"

# Create Database

- Create Database in Database Projects Tab 
  - Create all directories in Database Projects Tab
- Add *dbo* directory
- Add *Tables* directory to *dbo* directory
- Create Tables in *Tables*
- Publish Database

### Publish Database Steps

- Database Projects Tab
- Right Click Database > Publish
- Publish to an existing SQL server
- Don't use profile
- localhost [localhost: \<default> ... ]
- Click name of database creating
- Publish

# Add Projects to Solution

- `dotnet sln add .\BlazorDirectory\`
- `dotnet sln add .\ClassLibraryDirectory\`
- `dotnet sln add .\DatabaseDirectory\`

### Add Project Reference

- Blazor needs a reference to the Class Library
- `dotnet add reference ..\ClassLibraryDirectory\ClassLibrary.csproj`

# Add Connection String

- Added to Console/BlazorApp `appsettings.json`
- `"Default": "Data Source=localhost; Database=BlazorDatabase; Integrated Security=sspi; TrustServerCertificate=True;"`

