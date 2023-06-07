# Dotnet-Study-Projects
Various projects and tutorials to learn Dotnet

# VSCode Project Setup

- Create a Solution
    - CMD: `dotnet new sln --name <SolutionName>`
- Add Projects to solution
    - CMD: `dotnet sln add <ProjectFolder>/<ProjectFile>`
    - Ex1: `dotnet sln add DataLibrary/DataLibrary.csproj`
- List Solutions in Project
    - CMD: `dotnet sln <SolutionFileName> list
    - Exa: `dotnet sln MySolution.sln list`

### Types of Projects

- Create C# Class Library
    - CMD: `dotnet new classlib -o <FolderName>`
- Create Blazor Server
    - CMD: `dotnet new blazorserver --name <ProjectName>`
- Create Blazor Web Assembly
    - CMD: `dotnet new blazorwasm --name <ProjectName>`
- Run dotnet Project
    - CMD: `dotnet run`