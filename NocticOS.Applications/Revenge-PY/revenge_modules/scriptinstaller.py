# scriptinstaller.py

import git
from revenge_modules import revengedependencies

class ScriptInstaller:
	def InstallPrompt():
		currentRepo = ""
		currentRepo = input("Input the repository you want to install: ")
		if revengedependencies.hasnocticos == True:
			ScriptInstaller.NocticOSPrompt(currentRepo)
		else:
			ScriptInstaller.InstallScript(currentRepo)

	def NocticOSPrompt(daRepo):
		print("NOTICE: You have NocticOS installed! Would you like to install your script for NocticOS? (Y/N): ")
		the_options = input()
		if the_options == "Y" or the_options == "y":
			ScriptInstaller.InstallScript(daRepo)
		elif the_options == "N" or the_options == "n":
			print("Going back to Prompt...")
			ScriptInstaller.InstallPrompt()
		else:
			print("ERROR: Unknown Char, " + the_options)


	def InstallScript(curRepo):
		if revengedependencies.hasnocticos == True:
			git.Git('~/NocticOS').clone(curRepo)
		else:
			git.Git('~/Revenge').clone(curRepo)
