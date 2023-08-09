# CLI Creation Lines

- Solution: `dotnet new sln`
- Console App: `dotnet new console -f net7.0`
- Class Library: `dotnet new classlib -f net7/0`

# Create Database

- Create tables in Database Projects Tab
- Publish Database

# Add Projects to Solution

- `dotnet sln add .\SQLContactsDB\`
- `dotnet sln add .\SqlServerUI\`
- `dotnet sln add .\DataAccessLibrary\`

# Add Connection String

- Added to Console/BlazorApp `appsettings.json`
- `"Default": "Data Source=localhost; Database=SqlContactsDB; Integrated Security=sspi; TrustServerCertificate=True;"`
