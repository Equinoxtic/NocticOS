# taskbar.py

class Taskbar:
	def Create(doNewLine):
		if doNewLine:
			print("\n")
		taskbarItems = [
			"\n		( [-sets] Settings", 
			"	|	[-inst] Script Installer", 
			"	|	[-term] Terminal )"
		]	
		for i in taskbarItems:
			print(i, end = " ")
