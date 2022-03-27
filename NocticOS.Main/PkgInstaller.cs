/*
Pretty much the same as the "LinkOpener" class
*/

using System;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using NocticOS.Lib;
using LibGit2Sharp;

namespace NocticOS.Main
{
	public class PkgInstaller
	{
		public void InstallPackage()
		{
			Program program = new Program();
			string? pkgUrl = "";
			string? path = "";
			Console.Write("\nInput the package you want to install: ");
			pkgUrl = Console.ReadLine();
			Console.Write("\nInput the path for the repository to be cloned to: ");
			path = Console.ReadLine();
			if (String.IsNullOrEmpty(pkgUrl) || String.IsNullOrEmpty(path)) {
				Throw nullUrl = new Throw();
				nullUrl.CreateThrow(
					false,
					"nu",
					"Null / Empty URL, please input the URL again, later.",
					true
				);
				program.DoReturn(false);
			} else {
				Repository.Clone(pkgUrl, path);
			}
			Console.Write("\nSuccessfully installed package.\n");
			program.DoReturn(false);
		}
	}
}
