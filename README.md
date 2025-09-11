# C# Playground

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![macOS](https://img.shields.io/badge/macOS-000000?style=for-the-badge&logo=apple&logoColor=white)
![Rider](https://img.shields.io/badge/JetBrains%20Rider-000000?style=for-the-badge&logo=rider&logoColor=white&labelColor=crimson)

Small console apps and practice snippets while playing around with C# and .NET on macOS.

---

## Repository Map

````
checking-out-C-/
├─ FirstConsoleApp/     # Minimal console starter (Hello, World!)
├─ lesson-code/         # Small examples & practice snippets
├─ Word-Mitschrift/     # Notes and Word/RTF materials
├─ .idea/               # IDE metadata
├─ .DS_Store            # macOS file (can be ignored)
└─ README.md
````

> All C# code targets .NET SDK **6+** unless stated otherwise.

---

## Quickstart

### 1) Requirements
- .NET SDK **6+** (`dotnet --info`)
- macOS
- JetBrains Rider *(optional but recommended)*

### 2) Clone & build

```bash
git clone https://github.com/999Gabriel/checking-out-C-.git
cd checking-out-C-

# restore and build
dotnet restore
dotnet build
````

### 3) Run

Run a specific project from the repo root using `--project`:

```bash
# Example: run the console starter
dotnet run --project FirstConsoleApp
````

> Tip: Press **Ctrl+C** to stop a running app in the terminal.

---

## What’s Inside

### `FirstConsoleApp/`
A minimal console application that prints a greeting and a short intro—perfect to verify your toolchain works.

### `lesson-code/`
Assorted, self‑contained snippets for learning (e.g., variables, conditionals, loops, `int.TryParse`, simple I/O).  
Copy snippets into a project to run them, or create a new sample project with:

```bash
dotnet new console -n ScratchPad
cd ScratchPad
code .   # or open with Rider
````

### `Word-Mitschrift/`
Notes and Word/RTF exports used alongside the exercises.

---

## Using Rider

1. Open the repository folder in **JetBrains Rider**.
2. In **Solution Explorer**, right‑click a project → **Set as Startup Project**.
3. Click **Run** ▶ or **Debug** 🐞.

---

## Common .NET CLI Commands

```bash
# build & run current folder
dotnet build
dotnet run

# create a new console project
dotnet new console -n MyConsoleApp

# add a NuGet package
dotnet add package <PackageName>

# (optional) create a solution and add projects
dotnet new sln -n Playground
dotnet sln add FirstConsoleApp/FirstConsoleApp.csproj
```

---

## Troubleshooting

- **SDK not found**: Install .NET SDK 6+ (macOS); verify with `dotnet --info`.
- **Rider can’t run project**: Ensure the intended project is set as **Startup**.
- **macOS file noise**: `.DS_Store` can be ignored or added to `.gitignore`.

---

## License

No license specified yet.

---

**Made by [999Gabriel](https://github.com/999Gabriel)** 🚀
