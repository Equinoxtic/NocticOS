# templatescript.py

from revenge_modules import scriptsampler

class Script:
	def StartScript():
		scriptsampler.ThrowSample()

	def RunScript():
		Script.StartScript()

Script.RunScript()
