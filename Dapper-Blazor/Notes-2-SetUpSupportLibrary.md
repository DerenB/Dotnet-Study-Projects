# Setting up the Support Library

### Add NuGet Packages

- View > Command Palette > NuGet: Open NuGet Gallery
- Packages properly added are listed in the `.csproj` file
- Add: "Dapper"
- Add: "System.Data.SqlClient"
- Add: "Microsoft.Extensions.Configuration.Abstractions"

### Directories

- Add "DataService" Directory
  - This directory is for data services
- Add "DataAccess" Directory
  - This directory talks to the database
  - Not exposed outside of the support library
  - Not in dependency injection
- Add "Models" Directory
- Add Imports to *BlazorApp* > `_Imports.razor`
  - `@using SupportLibrary.Models`

# Setup Models

- Add a model for every table in the database
  - The model should have the same variables as the table columns
  - Extract the Model to an interface
