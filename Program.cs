using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS
{
	class Program
	{
		public static void Main(String[] args)
		{
			CommandSwitch cmdSwitch = new CommandSwitch();

			var curSelected = "";
			
			Console.WriteLine("\nNocticOS - Version (1.1.5)");
			Console.Write("Type in 'help' to get started.");
			Console.Write("\n> ");

			curSelected = Console.ReadLine();

			cmdSwitch.OpenCommand(curSelected);
		}
	}
}
