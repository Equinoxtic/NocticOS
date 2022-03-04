# createdcommand.py

from revenge_lib import terminalcommandlist

codeSuccess = ""

class CreatedCommand:
	def CreateCommand(name, type, desc, doDebug):
		if type == 'command':
			if doDebug == True:
				try:
					codeSuccess = "Success"
					print("Command: " + name + ", successfully loaded")
				except:
					codeSuccess = "Failed"
					print("ERROR, failed to load command: " + name)
		elif type == "list":
			terminalcommandlist.CmdList.PushList(name, desc)
					