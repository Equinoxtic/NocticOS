# # versionchecker.py

from revenge_modules import version

daVersion = version.Version.current_version

class VersionChecker:
	def CheckVersion(leVersion):
		if daVersion != "1.0.0":
			print("Version: " + leVersion + ", is outdated.\nPlease update to the latest and stable release of revenge")
