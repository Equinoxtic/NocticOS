# throwShit.py

import revengereturn

class ThrowShit:
	def ThrowContinue(message, shouldNewLine):
		if shouldNewLine:
			print("\n" + message)
		else:
			print(message)
		input()

	def throwChoiceYorN(message, shouldNewLine):
		if shouldNewLine:
			print("\n")
		choiceStr = input(message)
		if choiceStr == "Y" or choiceStr == "y":
			revengereturn.RevengeReturn.DoReturn(False)
		elif choiceStr == "N" or choiceStr == "n":
			ThrowShit.ThrowContinue("Press any key to exit...", True)
		else:
			ThrowShit.ThrowContinue("Unknown Character: " + choiceStr + "\nPress any key to exit...", True)
