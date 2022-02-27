:: Batch Script for installing packages

@ECHO OFF

:: Options Prompt
:OPTIONSPROMPT

ECHO:
ECHO [1] INSTALL
ECHO:
ECHO [2] UNINSTALL
ECHO:
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
	cd..
	dotnet add package Newtonsoft.Json
	ECHO:
)

PAUSE

GOTO OPTIONSPROMPT

:: Uninstall
:UNINSTALLPACKAGES

SET /P OPTS=Uninstall Packages? [y/n]: 

IF %OPTS%=="y" (
	ECHO:
	cd..
	dotnet remove package Newtonsoft.Json
	ECHO:
	PAUSE
)
