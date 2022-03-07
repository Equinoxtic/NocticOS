# NocticOS Build Instructions

## Installing NocticOS

Here are a two methods of installing NocticOS.

### Downloading the ZIP

* Click the green Button that says "Code"

![image](https://user-images.githubusercontent.com/86795271/149380961-f8a4e859-d6fc-4856-bee4-44a9033277f3.png)

* After that, click "Download ZIP"
* Wait for the installation to finish.
* It is recommended to extract the folder to your User files `C:\Users\<YourUser>`

### Cloning the Repository

Make sure you have **Git** installed for this.

**Git:** <https://git-scm.com>

* Open up your desired Terminal (Command Prompt, PowerShell or Windows Terminal).
* Copy and paste: `git clone https://github.com/Equinoxtic/NocticOS`
* Let it finish.
* Now check if the NocticOS folder is in the directory `C:\Users\<YourUser>`, You should see it there.

### Additional Note

If you wanna get an older version of NocticOS, please visit the releases page.

**Link:** <https://github.com/Equinoxtic/NocticOS/releases>

## Installing The .NET Framework and VS-Code

* Install the **.NET Framework 6.0.**
* Install **Visual Studio Code.**
* Install Extensions for **C# support** in VS-Code

## Download Links (.NET SDK and Runtime)

| **Operating System** | **SDK Installers** | **SDK Binaries** | **Runtime Installers** | **Runtime Binaries** |
| :--------------: | :------------: | :----------: | :----------------: | :--------------: |
| **Windows**      | [ARM64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-windows-arm64-installer) \| [x86](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-windows-x86-installer) \| [x64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-windows-x64-installer) | [ARM64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-windows-arm64-binaries) \| [x86](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-windows-x86-binaries)  \| [x64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-windows-x64-binaries) | [ARM64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.1-windows-arm64-installer) \| [x86](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.1-windows-x86-installer) \| [x64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.1-windows-x64-installer) | [ARM64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.1-windows-arm64-binaries) \| [x86](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.1-windows-x86-binaries) \| [x64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.1-windows-x64-binaries) |
| **MacOS**        | [ARM64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-macos-arm64-installer) \| [x64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-macos-x64-installer) | [ARM64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-macos-arm64-binaries) \| [x64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-macos-x64-binaries) | [ARM64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.1-macos-arm64-installer) \| [x64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.1-macos-x64-installer) | [ARM64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.1-macos-arm64-binaries) \| [x64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.1-macos-x64-binaries) |
| **Linux**        | [Package Manager Instructions](https://docs.microsoft.com/dotnet/core/install/linux?WT.mc_id=dotnet-35129-website) | [ARM32](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-linux-arm32-binaries) \| [ARM32 Alpine](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-linux-arm32-alpine-binaries) \| [ARM64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-linux-arm64-binaries) \| [ARM64 Alpine](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-linux-arm64-alpine-binaries) \| [x64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-linux-x64-binaries) \| [x64 Alpine](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.101-linux-x64-alpine-binaries) | [Package Manager Instructions](https://docs.microsoft.com/dotnet/core/install/linux?WT.mc_id=dotnet-35129-website) | [ARM32](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.1-linux-arm32-binaries) \| [ARM32 Alpine](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.1-linux-arm32-alpine-binaries) \| [ARM64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.1-linux-arm64-binaries) \| [ARM64 Alpine](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.1-linux-arm64-alpine-binaries) \| [x64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.1-linux-x64-binaries) \| [x64 Alpine](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.1-linux-x64-alpine-binaries) |


## Download Links (Visual Studio Code)

| **Operating System** | **64 Bit** | **32 Bit** | **ARM64** | **ARM** | **Universal** | **Intel Chip** | **Apple Silicon** |
| :------------------: | :--------: | :--------: | :-------: | :-----: | :-----------: | :------------: | :---------------: |
| **Windows**		   | <https://code.visualstudio.com/docs/?dv=win64user> | <https://code.visualstudio.com/docs/?dv=win32user> | - | <https://code.visualstudio.com/docs/?dv=win32arm64user>` | - | - | - |
| **MacOS**            | - | - | - | - | <https://code.visualstudio.com/docs/?dv=osx> | <https://code.visualstudio.com/docs/?dv=darwinx64> | <https://code.visualstudio.com/docs/?dv=darwinarm64> |
| **Linux**            |

* **C# Extension:** <https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp>
* **C# IDE Extensions:** <https://marketplace.visualstudio.com/items?itemName=jchannon.csharpextensions>

### ADDITIONAL NOTES WHEN INSTALLING .NET

* When running NocticOS download the **Runtime Binaries.** (Running without the source code)
* When building NocticOS download the **SDK Binaries.** (Building the source code)
* For **64-bit** users install the **x86 binaries.**
* For **32-bit** users install the **x64 binaries.**

Once you have followed those steps. open up your desired Terminal (Command Prompt, PowerShell or Windows Terminal)

Now type in, `cd NocticOS`, and then `code .`

After running `code .` it should open up VS-Code and the project.

## Building NocticOS

* Open up your desired Terminal.
* Type in `cd NocticOS`, and then `dotnet build` to build the program.
* Another way to build NocticOS is to open up the `BuildNocticOS.bat` file. (Can be found in `NocticOS.BatchFiles` directory.)
* If the build has successfully finished, you can proceed to running NocticOS.

## Running NocticOS

* Open up your desired Terminal again.
* Type in `cd NocticOS`, and then `dotnet run` to run the program.
* It's gonna take a few seconds before NocticOS starts.

And you're done!
