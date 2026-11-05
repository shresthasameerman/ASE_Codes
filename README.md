# ASE Codes

A collection of C# projects and exercises created for application software engineering practice.

## Projects

| Project | Description | Target framework |
| --- | --- | --- |
| [`Calculator`](./Calculator) | Windows Forms calculator supporting addition, subtraction, multiplication, division, decimals, percentages, sign changes, and chained operations. | .NET Framework 4.8 |
| [`Lab 1 Console Application`](./Lab%201%20Console%20Application) | Introductory console application demonstrating program startup and constructor execution. | .NET 10 |
| [`linesandshapes`](./linesandshapes) | Windows Forms drawing and animation demo featuring a moving car, rotating wheels, and interactive controls. | .NET 10 for Windows |

## Requirements

- Visual Studio 2022 or later with the **.NET desktop development** workload
- .NET 10 SDK for the console and `linesandshapes` projects
- Windows for the Windows Forms projects
- .NET Framework 4.8 Developer Pack for `Calculator`

## Getting started

Clone the repository:

```bash
git clone https://github.com/shresthasameerman/ASE_Codes.git
cd ASE_Codes
```

Open any of the solution files in Visual Studio:

- `Calculator/Calculator.slnx`
- `Lab 1 Console Application/Lab 1 Console Application.slnx`
- `linesandshapes/linesandshapes.slnx`

Select the desired project as the startup project, then press **F5** to build and run it.

## Running from the command line

Run the console project with:

```bash
dotnet run --project "Lab 1 Console Application/Lab 1 Console Application"
```

Build the Windows Forms drawing project on Windows with:

```bash
dotnet build linesandshapes/linesandshapes/linesandshapes.csproj
```

The `Calculator` project targets .NET Framework 4.8 and is best built and run from Visual Studio on Windows.

## `linesandshapes` controls

- **Start / Stop**: Start or pause the car animation
- **Reverse**: Reverse the car's direction
- **Faster / Slower**: Adjust the animation speed
- **Color**: Change the car color
- **Reset**: Return the car and animation to their initial state

## Repository layout

```text
ASE_Codes/
├── Calculator/
├── Lab 1 Console Application/
├── linesandshapes/
└── README.md
```

## License

No license has been specified for this repository.
