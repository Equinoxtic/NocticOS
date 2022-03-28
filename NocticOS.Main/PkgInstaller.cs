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
			if (String.IsNullOrEmpty(pkgUrl)) {
				Throw nullUrl = new Throw();
				nullUrl.CreateThrow(
					false,
					"nu",
					"Null / Empty URL, please input the URL again, later.",
					true
				);
			}

			Console.Write("\nInput the path for the repository to be cloned to: ");
			path = Console.ReadLine();
			if (String.IsNullOrEmpty(path)) {
				Throw nullPath = new Throw();
				nullPath.CreateThrow(
					false,
					"np",
					"Null / Empty Path, please input the path again, later.",
					true
				);
			}

			if (!String.IsNullOrEmpty(pkgUrl) || !String.IsNullOrEmpty(path)) {
				Repository.Clone(pkgUrl, path);
				Console.Write("\nSuccessfully installed package.\n");
				program.DoReturn(false);
			} else {
				Throw nullUrlAndPath = new Throw();
				nullUrlAndPath.CreateThrow(
					false,
					"nup",
					"Null / Empty URL / Path, please input the Path and URL again, later.",
					true
				);
				program.DoReturn(false);
			}
		}
	}
}
