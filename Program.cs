using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO.Program;
using Main.Base.Program;
using NocticUtility;

namespace NocticOS
{
	class Program
	{
		public static void Main(String[] args)
		{
			ISO_Mode IsoMain = new ISO_Mode();
			Base_Mode baseMain = new Base_Mode();
			NocticCmdList Cmdls = new NocticCmdList();
			var curDir = @"C:\NocticOS";
			System.IO.Directory.CreateDirectory(curDir);
			var curSelected = "";
			
			Console.WriteLine("\nNocticOS - Version (1.0.23)");
			Console.Write("Type in 'help' to get started.");
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
