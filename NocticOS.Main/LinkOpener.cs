using System;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using NocticOS.Lib;

namespace NocticOS.Main
{
	public class LinkOpener
	{
		public void OpenLink(string? url = "")
		{
			Program program = new Program();
			if (!String.IsNullOrEmpty(url)) {
				url = url.Replace("&", "&^");
				Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
			} else {
				LinkOpenPrompt();
			}
			program.DoReturn(false);
		}

		void LinkOpenPrompt()
		{
			Program program = new Program();
			string? url = "";
			Console.Write("\nInput a URL:\n");
			url = Console.ReadLine();
			if (String.IsNullOrEmpty(url)) {
				Throw emptyValue = new Throw();
				emptyValue.CreateThrow(
					false,
					"ev",
					"Empty value. Please try again.",
					true
				);
				program.DoReturn(false);
			} else {
				url = url.Replace("&", "&^");
				Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
			}
		}
	}
}
