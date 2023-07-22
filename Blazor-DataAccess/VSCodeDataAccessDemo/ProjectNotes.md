
# Create Files

1. Create Solution File
   1. CMD: `dotnet new sln`
   2. Name defaults to Parent Directory name
   3. Solutions without default name can't add server to project
2. Create Blazor Server App (empty) project
   1. CMD: `dotnet new blazorserver-empty --name BlazorApp`
3. Create Class Library project
   1. CMD: `dotnet new classlib --name SupportLibrary`
4. Create Database project
   1. Done in the "Database Projects" tab in VSCode
5. Add Projects to Solution
   1. CMD: `dotnet sln add .\ProjectDatabase\ProjectDatabase.sqlproj`
   2. CMD: `dotnet sln add .\BlazorApp\BlazorApp.csproj`
   3. CMD: `dotnet sln add .\SupportLibrary\SupportLibrary.csproj`

# Setup Class Library

1. Delete default class `Class1.cs`
2. Add reference to the class library to Blazor App
   1. Add to Blazor Project File
   2. `BlazorApp\BlazorApp.csproj`
```
<ItemGroup>
    <ProjectReference Include="..\SupportLibrary\SupportLibrary.csproj" />
</ItemGroup>
```
3. Create a `Data` directory
   1. Data services in this directory
4. Create a `DataAccess` directory
   1. Directly talks to the database
   2. Not exposed outside of the support library for internal use
   3. Not in dependency injection 

# Set up Database

1. Create the folder structure
   1. Create folder `dbo`
   2. In DBO create folder `Stored Procedures`
   3. In DBO create folder `Tables`
2. Create the Tables
   1. Right Click Tables Directory > Add Table
   2. Add scripts for table columns
3. Publish Database
   1. Right click database in Database Projects tab
   2. Publish
   3. Publish to an existing SQL server
   4. Don't use profile
   5. Click default
   6. Click the corresponding file name
   7. Publish
   8. Check in SSMS that it was published
4. Add the connection string
   1. Open `appsettings.json` in the blazor project 
   2. Add this codeblock to connect to the database
```
"ConnectionStrings": {
   "SQLDB": "Data Source=localhost;Database=ProjectDatabase;IntegratedSecurity=sspi;TrustServerCertificate=True;"
}
```

