
# Grobocopy

Grobocopy is a graphical user interface (GUI) for the robocopy command-line tool. Robocopy is a powerful tool that can copy files and directories between local and remote locations, with many options to customize the operation. It is especially useful for backing up data, synchronizing folders, and migrating files across different drives or networks.

![Screenshot](https://github.com/dmaccormac/Grobocopy/blob/main/Grobocopy/Resources/screenshot.png)

## Features
- Easily browse and select source and destination folders.
- Confguration options sorted by tab: 
    - Copy: Choose options like copying subdirectories, mirroring, or handling file attributes.
    - File Throttling: Control file transfer rates and sizes for optimized performance.
    - File Selection: Include or exclude files based on attributes, size, or age.
    - Retry Options: Set retry limits and wait times for failed copies.
    - Logging: Save detailed logs of the copy process for review.
    - Job: Save or load job configurations for reuse.
- Command Preview: View the generated robocopy command before execution.
- Command Output: View the command progress in realtime in the output section. 

## Getting Started

### Prerequisites
- Windows operating system.
- .NET 8 runtime installed.

### Installation
1.	Download the latest release [here](https://github.com/dmaccormac/Grobocopy/releases)
2.	Extract the downloaded files to a folder of your choice.
3.	Run setup.exe to start the application installer.

## How to Use
1.	Select Source and Destination folders:
- Click the Browse buttons next to the Source and Destination Folder fields to select folders.

2.	Configure Options: 
- Use the tabs in the Options section to configure advanced settings.

3.	Preview the Command:
- Click the Preview button to see the generated robocopy command in the Command Preview field.

4.	Start the Copy:
- Click the Start button to execute the copy operation. The progress and output will be displayed in the Output section.

5.	Copy the Command (Optional):
- Click the Copy button to copy the generated robocopy command to your clipboard for external use.

## Contributing
Contributions are welcome! Feel free to fork the repository and submit pull requests.

## Feedback
Please send feedback and suggestions to dmaccormac@gmail.com.

## License
This project is licensed under the MIT License. See the LICENSE file for details.

## Acknowledgments
Grobocopy is built on top of the robust robocopy tool provided by Microsoft.