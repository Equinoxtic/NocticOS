# terminalcommandlist.py

import cmd


class CmdList:
	def PushList(currentObj, currentDescription):
		curObj = currentObj
		curDesc = currentDescription
		cmdLs = []
		cmdLs.append(curObj + curDesc)
		for i in cmdLs:
			print(i)
