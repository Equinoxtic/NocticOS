# revenge.py

from revenge_modules import throwShit
from revenge_modules import asciiprntr
from revenge_modules import cursorchar
from revenge_modules import taskbar
from revenge_modules import textdivider
from revenge_modules import commandlist
from revenge_modules import scriptinstaller
from revenge_modules import versionchecker
from revenge_modules import logintouser
from revenge_modules import version
from revenge_modules import revengedependencies
from revenge_modules import builddesc
# from ExternalScripts import (module)

class Revenge:
	# Create
	def Create():

		# ASCII Printer for title
		# Exclusive ASCII printer for REVENGE
		asciiprntr.ASCIIPrntr.PrntDefTitle(True)

		# Command List
		# Prints out the command list
		commandlist.CommandList.CreateCommandList()	

		# Taskbar
		# Standard taskbar for REVENGE
		taskbar.Taskbar.Create(True)

		# Text divider
		# Divider for seperating large amounts of text
		textdivider.TextDivider.CreateNewDivider("-", 120, True, False)

		# BuildDescription
		# Display an output for the creators of REVENGE and the build version
		builddesc.BuildDescription.DoCreate(True)

		# Text divider
		# Divider for seperating large amounts of text
		textdivider.TextDivider.CreateNewDivider("-", 120, True, False)

		# CursorChar preferencing
		# Allows you to have a custom cursor when inputting
		cursorchar.CursorChar.CursorCharPrefs("\n[>>>]: ", False)

		# code-start

		if revengedependencies.revenge_depends == "main":
			versionchecker.VersionChecker.CheckVersion(version.Version.current_version)				

		varInput = input()

		if varInput == "-liu":
			logintouser.LogIntoUser.RunPrompt()
		elif varInput == "-inst":
			scriptinstaller.ScriptInstaller.InstallPrompt()
		elif varInput == "exit":
			throwShit.ThrowShit.ThrowContinue("Press any key to exit...", True)
		else:
			throwShit.ThrowShit.ThrowContinue("Command: " + varInput + ", does not exist\nPress any key to exit... ", True)

		# code-end

	# Run
	def Run():
		Revenge.Create()

Revenge.Run()
