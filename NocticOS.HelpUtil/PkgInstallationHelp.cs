using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS.HelpUtil
{
	public class PkgInstallationHelp
	{
		string[] pkgInstallLs = {
			"-help - Displays the information for the 'pkg' command.",
			"-install - Standard Installation Prompt."
		};
		
		public void OpenPkgInstallerHelp(bool isMissingParams)
		{
			Program program = new Program();
			Options pkgInstallOpts = new Options();
			Throw missingParams = new Throw();

			if (!isMissingParams) {
				Console.Write("\nPackage Installer Commands:\n\n");
				pkgInstallOpts.PushOptions(pkgInstallLs, pkgInstallLs.Length, true);
			} else {
				missingParams.CreateThrow(
					false,
					"mp",
					"Missing Parameters, please enter the following and try again:\n\n",
					true
				);
				pkgInstallOpts.PushOptions(pkgInstallLs, pkgInstallLs.Length, true, "pkg");
			}

			program.DoReturn(false);
		}
	}
}
