# GitHub Workflow Test App

This repository is a small monorepo-style .NET 8 app for testing the GitHub Actions workflows.

## Layout

- `Common/` shared dependency used by both solutions
- `SolutionA/` solution A
- `SolutionB/` solution B

## Workflow behavior

- Changes under `SolutionA/**` deploy Solution A and then Solution B
- Changes under `SolutionB/**` deploy only Solution B
- Changes under `Common/**` deploy both solutions

## Local build

```powershell
dotnet build SolutionA\src\SolutionA\SolutionA.csproj
dotnet build SolutionB\src\SolutionB\SolutionB.csproj
```

## Local test

```powershell
dotnet test SolutionA\src\SolutionA\SolutionA.csproj
dotnet test SolutionB\src\SolutionB\SolutionB.csproj
```

## Local run

```powershell
dotnet run --project SolutionA\src\SolutionA\SolutionA.csproj
dotnet run --project SolutionB\src\SolutionB\SolutionB.csproj
```
