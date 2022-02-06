:: Batch Script for installing pacakges for NocticOS

@ECHO OFF


:: Install Prompt
:INSTALLNEWTONPROMPT

SET /P OPTS=Install Packages for NocticOS? [y/n]: 

IF %OPTS%=="y" GOTO INSTALLNEWTON

IF %OPTS%=="n" ECHO	 Operation Cancelled.


:: Installation
:INSTALLNEWTON

ECHO Adding Newtonsoft.Json... 

ECHO: 

dotnet add package Newtonsoft.Json

EXIT
