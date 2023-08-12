# Empty Project Setup

### Add NuGet Packages

- View > Command Palette > NuGet: Open NuGet Gallery
- Packages properly added are listed in the `.csproj` file
- Add: "Microsoft.Extensions.Configuration"
- Add (maybe): "Microsoft.Extensions.Configuration.Json"

### Add Files

1. Create directory: *Models* 
2. Create directory: *Shared*
   1. Add *Layout.razor* to this directory
   2. CMD: `dotnet new razorcomponent -n Layout`
3. Add the directories to Imports
   1. File: `_Imports.razor`
   2. Add: `@using BlazorAppName`
   3. Add: `@using BlazorAppName.Shared`
   4. Add: `@using BlazorAppName.Models`
4. Check the reference to Layout in `App.razor`
   1. App.razor has to reference the layout file
   2. Defaults to "MainLayout"
   3. Change all instances to "Layout"
5. Add Bootstrap 5 references to `_Host.cshtml`
   1. <mark>**TODO**</mark> : Bootstrap lines

# Models

- Create a Model for every model that was created in the support library
- Add "Display" to the model name to distinguish the model from the support library model
- Extend the interface from the support library

# Layout Page Setup

1. Add inherit line at top
   1. `@inherits LayoutComponentBase`
2. Add a `@Body` somewhere on the page
3. Add CSS Isolation
   1. Add line to `_Host.cshtml` Head
   2. Add: `<link href="ProjectName.styles.css" rel="stylesheet" />`



