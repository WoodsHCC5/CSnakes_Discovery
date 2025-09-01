# 🐍 CSnakes Discovery

[![.NET 9](https://img.shields.io/badge/.NET-9-512BD4?style=flat-square&logo=.net)](https://dotnet.microsoft.com/)
[![Python 3.12](https://img.shields.io/badge/Python-3.12-3776AB?style=flat-square&logo=python&logoColor=white)](https://www.python.org/)
[![CSnakes](https://img.shields.io/badge/CSnakes-Runtime-green?style=flat-square)](https://github.com/tonybaloney/CSnakes)

A simple demonstration project showcasing how to integrate Python code with .NET using the **CSnakes** library. This project serves as a practical example for developers looking to call Python functions from C# applications.

## 🎯 Purpose

This project demonstrates:
- ✅ How to set up CSnakes with .NET 9
- ✅ Calling Python functions from C# code
- ✅ Proper project configuration for Python file deployment
- ✅ Working with Python return values in C#

## 🚀 Quick Start

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Git

### Installation & Running

1. **Clone the repository**
git clone https://github.com/WoodsHCC5/CSnakes_Discovery.git cd CSnakes_Discovery

2. **Build the project**
dotnet build

3. **Run the application**
dotnet run


**Expected Output:**
Python


## 📁 Project Structure
CSnakes_Discovery/ ├── Program.cs          # Main C# application entry point ├── aot_demo.py         # Python module with demonstration functions ├── CSnakes_Test.csproj # Project configuration └── README.md           # This file


## 🔧 Key Configuration

The critical configuration that enables Python file deployment is in the `.csproj` file:

<ItemGroup> 
    <AdditionalFiles Include="aot_demo.py"> 
        <CopyToOutputDirectory>Always</CopyToOutputDirectory> 
    </AdditionalFiles> 
</ItemGroup>


> **💡 Important Note:** This `AdditionalFiles` configuration is essential and often missing from tutorials. Without it, the Python file won't be copied to the output directory, causing runtime errors.

## 📖 How It Works

1. **Python Side** (`aot_demo.py`):
```
def cool_things() -> list[str]: 
"""Returns a list of cool technologies""" 
    return ["Python", "C#", "CSnakes"]
```

2. **C# Side** (`Program.cs`):
```
var env = app.Services.GetRequiredService<IPythonEnvironment>(); 
var quickDemo = env.AotDemo(); 
var coolThings = quickDemo.CoolThings(); 
Console.WriteLine(coolThings[0]);
```

## 🛠️ Technologies Used

- **[.NET 9](https://dotnet.microsoft.com/)** - Modern cross-platform framework
- **[Python 3.12](https://www.python.org/)** - Python runtime
- **[CSnakes.Runtime](https://github.com/tonybaloney/CSnakes)** - Python-.NET interop library

## 🤝 Contributing

Feel free to open issues or submit pull requests if you find ways to improve this demonstration project!

## 📄 License

This project is provided as-is for educational and demonstration purposes.

---

**Found this helpful?** ⭐ Star this repository to help others discover it!
