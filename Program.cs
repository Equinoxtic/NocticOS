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
		
		static void MainProgram(bool showInfo = true)
		{
			CursorPrefs prefs = new CursorPrefs();
			UIConfiguration uiConfiguration = new UIConfiguration();
			TimeConfiguration timeConfiguration = new TimeConfiguration();
			CommandSwitch cmdSwitch = new CommandSwitch();
			string currentCursor = prefs.curCursor;
			string version =  "";
			string dotnetversion = Environment.Version.ToString();
			string timeStr = "";
			bool versionAllowed = uiConfiguration.showOSVersion;
			bool dotnetVersionAllowed = uiConfiguration.showDotnetVersion;
			bool timeAllowed = uiConfiguration.showTime;

			if (versionAllowed) {
				version = " - (1.1.5)";
			}

			if (timeConfiguration.hoursShowing) {
				timeConfiguration.minutesShowing = false;
				timeConfiguration.secondsShowing = false;
				timeStr = "HH";
			}
			
			if (timeConfiguration.minutesShowing) {
				timeConfiguration.hoursShowing = false;
				timeConfiguration.secondsShowing = false;
				timeStr = "mm";
			}
			
			if (timeConfiguration.secondsShowing) {
				timeConfiguration.hoursShowing = false;
				timeConfiguration.minutesShowing = false;
				timeStr = "ss";
			}
			
			if (timeConfiguration.showingAll) {
				timeStr = "HH:mm:ss";
			}

			if (showInfo) {
				Console.WriteLine("\nNocticOS" + version);
				Console.Write("Type in 'help' to get started.");
				if (dotnetVersionAllowed) {
					Console.Write("\n" + dotnetversion);
				}
			}

			if (timeAllowed) {
				Console.Write("\n" + "[" + DateTime.Now.ToString(timeStr) + "]" + currentCursor);
			} else {
				Console.Write("\n" + currentCursor);
			}

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

		public static void Main(String[] args) {
			MainProgram();
		}

		public void DoReturn(bool showInfo) {
			MainProgram(showInfo);
		}
	}
}
