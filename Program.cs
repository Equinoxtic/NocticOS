using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Main;
using NocticOS.Source;
using NocticOS.HelpUtil;

namespace NocticOS
{
	class Program
	{
		public static void Main(String[] args)
		{
			DirectoryBuilder DirBuilder = new DirectoryBuilder();
			HelpState helpState = new HelpState();
			InputState StandardInput = new InputState();

			var curSelected = "";
			
			Console.WriteLine("\nNocticOS - Version (1.1.4)");
			Console.Write("Type in 'help' to get started.");
			Console.Write("\n> ");
			curSelected = Console.ReadLine();

			switch (curSelected)
			{
				case "help" : helpState.OpenState(); break;
				case "input" : StandardInput.InputSelect(); break;
				case "build-dirs" : DirBuilder.DirBuild(); break;
				case "exit" : Console.WriteLine("Exiting program...\n"); Thread.Sleep(3000); break;
			}
		}
	}
}
