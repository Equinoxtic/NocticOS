# textdivider.py

class TextDivider:
	def CreateNewDivider(dividerChar, dividerLength, doNewLine, secondNewLine):
		if doNewLine:
			print("\n")
		print(dividerChar*dividerLength)
		if secondNewLine:
			print("\n")
