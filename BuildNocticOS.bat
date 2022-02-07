:: Batch Script for building NocticOS.

@ECHO OFF

GOTO BUILDPROMPT

:BUILDPROMPT

SET /P PROMPT_MSG=Would you like to build NocticOS? [y/n]: 

IF %PROMPT_MSG%==y (
	ECHO:
	dotnet build
	PAUSE
) ELSE IF %PROMPT_MSG%==n (
	ECHO:
	ECHO Operation Cancelled.
	PAUSE
)
