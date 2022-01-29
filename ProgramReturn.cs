using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS
{
    public class ProgramReturn
    {
        public void DoReturn(bool showInfo)
		{
			var curSelected = "";

			if (showInfo) {
				Console.WriteLine("\nNocticOS - Version (1.1.4)");
				Console.Write("Type in 'help' to get started.");
			}

			Console.Write("\n> ");
			curSelected = Console.ReadLine();

			switch (curSelected)
			{
				case "exit" : Console.WriteLine("Exiting program..."); Thread.Sleep(3000); break;
			}
		}
    }
}