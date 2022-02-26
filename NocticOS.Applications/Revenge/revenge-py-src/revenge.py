# revenge.py

from revenge_modules import throwShit
from revenge_modules import asciiprntr
from revenge_modules import cursorchar
from revenge_modules import taskbar
from revenge_modules.text_graphics import textdivider
from revenge_modules.revenge_util import commandlist
from revenge_modules.revenge_util import scriptinstaller
from revenge_modules.revenge_states.user_control import logintouser

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

		# CursorChar preferencing
		# Allows you to have a custom cursor when inputting
		cursorchar.CursorChar.CursorCharPrefs("\n[>>>]: ", False)

		# code-start

		varInput = input()

		if varInput == "-liu":
			logintouser.LogIntoUser.RunPrompt()
		elif varInput == "-inst":
			scriptinstaller.ScriptInstaller.InstallPrompt()
		else:
			throwShit.ThrowShit.ThrowContinue("Command: " + varInput + ", does not exist\nPress any key to exit... ", True)

		# code-end

	# Run
	def Run():
		Revenge.Create()

Revenge.Run()
