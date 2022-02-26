# scriptinstaller.py

import git

class ScriptInstaller:
	def InstallPrompt():
		currentRepo = ""
		currentRepo = input("Input the repository you want to install: ")
		ScriptInstaller.InstallScript(currentRepo)

	def InstallScript(curRepo):
		git.Git('~/Revenge').clone(curRepo)
