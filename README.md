
# Grobocopy

Grobocopy is a Windows Forms application that provides a graphical user interface for the `robocopy` command-line utility. 
It allows users to easily copy files and directories from a source to a destination folder.

## Features

- Select source and destination directories using a folder browser dialog.
- Display real-time output of the `robocopy` command in a text box.
- Asynchronous execution to keep the UI responsive.

## Requirements

- .NET 8.0
- Visual Studio 2022

## Getting Started

### Prerequisites

Ensure you have the following installed:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)

### Installation

1. Clone the repository:
2. Open the solution file `Grobocopy.sln` in Visual Studio 2022.
3. Build the solution to restore the necessary NuGet packages.

### Usage

1. Run the application by pressing `F5` or selecting `Debug > Start Debugging` in Visual Studio.

2. Use the `Browse` buttons to select the source and destination directories.

3. Click the `Start` button to begin the copy operation. The output of the `robocopy` command will be displayed in the output text box.

## Code Overview

### MainForm.cs

This file contains the main logic for the application, including:

- Event handlers for the `Browse` and `Start` buttons.
- Asynchronous execution of the `robocopy` command.
- Real-time output display in the text box.

### InitializeComponent Method

This method initializes the UI components and sets up their properties and event handlers.


## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

