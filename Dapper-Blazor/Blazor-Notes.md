# Empty Project Setup

1. Create directory: *Shared*
   1. Add *Layout.razor* to this directory
   2. CMD: `dotnet new razorcomponent -n Layout`
2. Add the directory to Imports
   1. File: `_Imports.razor`
   2. Add: `@using BlazorAppName`
   3. Add: `@using BlazorAppName.Shared`
3. Check the reference to Layout in `App.razor`
   1. App.razor has to reference the layout file
   2. Defaults to "MainLayout"
   3. Change all instances to "Layout"
4. Add Bootstrap 5 references to `_Host.cshtml`
   1. **To-Do** : Bootstrap lines

# Layout Page Setup

1. Add inherit line at top
   1. `@inherits LayoutComponentBase`
2. Add a `@Body` somewhere on the page
3. Add CSS Isolation
   1. Add line to `_Host.cshtml` Head
   2. Add: `<link href="ProjectName.styles.css" rel="stylesheet" />`



