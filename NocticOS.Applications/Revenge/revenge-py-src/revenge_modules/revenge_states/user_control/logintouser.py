# logintouser.py

import time
import os
from revenge_modules import throwShit

class LogIntoUser:
	def RunPrompt():
		userStr = ""
		userID = 0
		userStr = input("\nInput the user's username: ")
		userID = input("Input the user's ID: ")
		LogIntoUser.GetUserData(userStr, userID)

	def GetUserData(curname:str, curid:int):
		# sysCommandArr = [
		# 	'cd..', 'cd..', 'cd..',
		# 	'mkdir logs',
		# 	'cd logs',
		# 	'ni userdata.txt'
		# ]
		# for i in sysCommandArr: # pls tell me that this works
		# 	os.open(sysCommandArr[i])
		print("\n===== User Data =====\nUser's name: " + curname + "\nUser's ID: " + curid)
		throwShit.ThrowShit.throwChoiceYorN("Return to main console? [Y/N]: ", True)
