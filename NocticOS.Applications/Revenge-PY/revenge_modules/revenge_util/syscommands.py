# syscommands.py

import os

class SysCommands:
	def clearScreen():
		os.system("cls")

	def goToDirectory(dirTo):
		os.system("cd" + dirTo)

	def previousDirectory():
		os.system("cd..")
