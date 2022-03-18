using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Settings;
using NocticOS.Lib;

namespace NocticOS
{
	class Program
	{
		
		static string? curSelected;

		public static void Main(String[] args)
		{
			Throw unknownCmdThrow = new Throw();
			CommandSwitch cmdSwitch = new CommandSwitch();
			OSConfiguration prefs = new OSConfiguration();
			string currentCursor = prefs.curCursor;
			
			Console.WriteLine("\nNocticOS - Version (1.1.5)");
			Console.Write("Type in 'help' to get started.");
			Console.Write("\n" + currentCursor);

			curSelected = Console.ReadLine();

			if (String.Equals(curSelected, curSelected)) {
				unknownCmdThrow.CreateThrow(
					false,
					"unknownCmd",
					"Unknown command: " + curSelected + ", please try again.",
					false
				);
				cmdSwitch.OpenCommand("exit");
			} else {
				cmdSwitch.OpenCommand(curSelected);
			}
		}

		public void DoReturn(bool showInfo)
		{
			Throw unknownCmdThrow = new Throw();
			CommandSwitch cmdSwitch = new CommandSwitch();
			OSConfiguration prefs = new OSConfiguration();
			string currentCursor = prefs.curCursor;

			if (showInfo) {
				Console.WriteLine("\nNocticOS - Version (1.1.5)");
				Console.Write("Type in 'help' to get started.");
			}

			Console.Write("\n" + currentCursor);

			curSelected = Console.ReadLine();

			if (String.Equals(curSelected, curSelected)) {
				unknownCmdThrow.CreateThrow(
					false,
					"unknownCmd",
					"Unknown command: " + curSelected + ", please try again.",
					false
				);
				cmdSwitch.OpenCommand("exit");
			} else {
				cmdSwitch.OpenCommand(curSelected);
			}
		}
	}
}
