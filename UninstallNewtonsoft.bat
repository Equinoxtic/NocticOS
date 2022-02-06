:: Batch Script for uninstalling Newtonsoft for NocticOS

@ECHO OFF


:: Install Prompt
:UNINSTALLNEWTONPROMPT

SET /P OPTS=Uninstall Packages for NocticOS? [y/n]: 

IF %OPTS%=="y" GOTO UNINSTALLNEWTON

IF %OPTS%=="n" ECHO	 Operation Cancelled.


:: Installation
:UNINSTALLNEWTON

ECHO:

ECHO Removing Newtonsoft.Json... 

ECHO: 

dotnet remove package Newtonsoft.Json

ECHO:

PAUSE
