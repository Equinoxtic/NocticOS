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

## Installing .NET and VS-Code

* Install the .NET Framework 6.0.
* Install Visual Studio Code.
* Install Extensions for C# support in VS-Code

**Links:**

* **.NET Framework (6.0):** <https://dotnet.microsoft.com/en-us/>
* **Visual Studio Code:** <https://code.visualstudio.com>
* **C# Extension:** <https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp>
* **C# IDE Extensions:** <https://marketplace.visualstudio.com/items?itemName=jchannon.csharpextensions>

### ADDITIONAL NOTES WHEN INSTALLING .NET

* For x64 users install the x86 binaries.
* For x32 users install the x64 binaries.

Once you have followed those steps. open up your desired Terminal (Command Prompt, PowerShell or Windows Terminal)

Now type in, `cd NocticOS`, and then `code .`

After running `code .` it should open up VS-Code and the project.

## Building NocticOS

* Open up your desired Terminal.
* Type in `cd NocticOS`, and then `dotnet build` to build the program.
* Another way to build NocticOS is to open up the `BuildNocticOS.bat` file.
* If the build has successfully finished, you can proceed to running NocticOS.

## Running NocticOS

* Open up your desired Terminal again.
* Type in `cd NocticOS`, and then `dotnet run` to run the program.
* It's gonna take a few seconds before NocticOS starts.

And you're done!
