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
			CursorPrefs prefs = new CursorPrefs();
			CommandSwitch cmdSwitch = new CommandSwitch();
			string currentCursor = prefs.curCursor;
			
			Console.WriteLine("\nNocticOS - (1.1.5)");
			Console.Write("Type in 'help' to get started.");
			Console.Write("\n" + currentCursor);

			curSelected = Console.ReadLine();
			if (String.IsNullOrEmpty(curSelected)) {
				Throw emptyValue = new Throw();
				emptyValue.CreateThrow(
					false,
					"ev",
					"Empty Value, please try again.",
					true
				);
			} else {
				cmdSwitch.OpenCommand(curSelected);
			}
		}

		public void DoReturn(bool showInfo)
		{
			CursorPrefs prefs = new CursorPrefs();
			CommandSwitch cmdSwitch = new CommandSwitch();
			string currentCursor = prefs.curCursor;

			if (showInfo) {
				Console.WriteLine("\nNocticOS - (1.1.5)");
				Console.Write("Type in 'help' to get started.");
			}

			Console.Write("\n" + currentCursor);

			curSelected = Console.ReadLine();
			if (String.IsNullOrEmpty(curSelected)) {
				Throw emptyValue = new Throw();
				emptyValue.CreateThrow(
					false,
					"ev",
					"Empty Value, please try again.",
					true
				);
			} else {
				cmdSwitch.OpenCommand(curSelected);
			}
		}
	}
}
