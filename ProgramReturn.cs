using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO;
using Main.Base;
using NocticUtility;

namespace NocticOS
{
    public class ProgramReturn
    {
        public void DoReturn(bool showInfo)
		{
			ISO_Mode IsoMain = new ISO_Mode();
			Base_Mode baseMain = new Base_Mode();
			NocticCmdList Cmdls = new NocticCmdList();
			var curSelected = "";

			if (showInfo) {
				Console.WriteLine("\nNocticOS - Version (1.0.23)");
				Console.Write("Type in 'help' to get started.");
			}

			Console.Write("\n> ");
			curSelected = Console.ReadLine();

			switch (curSelected)
			{
				case "help" : Cmdls.OpenCmdList(); break;
				case "exit" : Console.WriteLine("Exiting program..."); break;
				case "iso" : IsoMain.IsoMode(true); break;
				case "base" : baseMain.BaseMode(true); break;
			}
		}
    }
}