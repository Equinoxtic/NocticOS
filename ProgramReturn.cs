using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS
{
    public class ProgramReturn
    {
        public void DoReturn(bool showInfo)
		{
			CommandSwitch cmdSwitch = new CommandSwitch();

			var curSelected = "";

			if (showInfo) {
				Console.WriteLine("\nNocticOS - Version (1.1.5)");
				Console.Write("Type in 'help' to get started.");
			}

			Console.Write("\n> ");

			curSelected = Console.ReadLine();

			cmdSwitch.OpenCommand(curSelected);
		}
    }
}