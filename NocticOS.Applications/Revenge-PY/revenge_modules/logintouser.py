# logintouser.py

import random
import time
import os
from revenge_modules import throwShit

lowerShit = "abcdefghijklmnopqrstuvwxyz"
upperShit = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
numbers = "0123456789"

string = lowerShit + upperShit + numbers

# epicly does bad practice move B)
length = 20
length2 = 20
length3 = 20
length4 = 24
token = "".join(random.sample(string, length))
token2 = "".join(random.sample(string, length2))
token3 = "".join(random.sample(string, length3))
token4 = "".join(random.sample(string, length4))

tokens = token + token2 + token3 + token4

class LogIntoUser:
	def RunPrompt():
		userStr = ""
		userID = 0
		userStr = input("\nInput the User (User#0000): ")
		userID = input("Input the User's ID: ")
		LogIntoUser.GetUserData(userStr, userID)

	def GetUserData(curname, curid):
		# sysCommandArr = [
		# 	'cd..', 'cd..', 'cd..',
		# 	'mkdir logs',
		# 	'cd logs',
		# 	'ni userdata.txt'
		# ]
		# for i in sysCommandArr: # pls tell me that this works
		# 	os.open(sysCommandArr[i])

		hackerShit = [
			"\nChecking if User: " + curname + " Exists...",
			"[/] User: " + curname + " Found.",
			"Checking if User ID: " + curid + " Exists...",
			"[/] User ID: " + curid + " Found.",
			"Disabling 2FA...",
			"[/] 2FA Disabled",
			"Grabbing Token...",
			"[/] Token grabbed.",
		]

		for i in hackerShit:
			print(i)
			time.sleep(3)

		print("\n===== User Data =====\nUser's name: " + curname + "\nUser's ID: " + curid + "\n2FA Disabled: True", "\nToken: mfa." + tokens)
		throwShit.ThrowShit.throwChoiceYorN("Return to main console? [Y/N]: ", True)
