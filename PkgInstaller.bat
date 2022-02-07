:: Batch Script for installing packages

@ECHO OFF

:: Options Prompt
:OPTIONSPROMPT

ECHO [1] INSTALL
ECHO [2] UNINSTALL
SET /P OPTS=Select an action: 

IF %OPTS%==1 (
	GOTO INSTALLPACKAGES
)

IF %OPTS%==2 (
	GOTO UNINSTALLPACKAGES
)

:: Install
:INSTALLPACKAGES

SET /P OPTS=Install Packages? [y/n]: 

IF %OPTS%==y (
	ECHO:
	dotnet add package Newtonsoft.Json
	ECHO:
)

PAUSE

:: Uninstall
:UNINSTALLPACKAGES

SET /P OPTS=Uninstall Packages? [y/n]: 

IF %OPTS%=="y" (
	ECHO:
	dotnet remove package Newtonsoft.Json
	ECHO:
	PAUSE
)
