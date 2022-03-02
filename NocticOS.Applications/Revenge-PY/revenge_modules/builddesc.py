# builddesc.py

from revenge_modules import revengedependencies

class BuildDescription:
	def DoCreate(doNewLine):
		creds = [
			"Created by: Equinoxtic			Revenge - Developer Release			OS: " + revengedependencies.cur_OS,
			"Co-Owner: Crossed			Tag: 1.45.3					API: Revenge-API",
			"Build-1.0.0				Python Version: Python 3.10.X			Code name: DeeDos"
		]
		if doNewLine == True:
			print("\n")
		for i in creds:
			print(i)
