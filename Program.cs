using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Main;
using NocticOS.Source;

namespace NocticOS
{
	class Program
	{
		public static void Main(String[] args)
		{
			DirectoryBuilder DirBuilder = new DirectoryBuilder();
			InputState StandardInput = new InputState();

			var curSelected = "";
			
			Console.WriteLine("\nNocticOS - Version (1.1.6)");
			Console.Write("Type in 'help' to get started.");
			Console.Write("\n> ");
			curSelected = Console.ReadLine();

			switch (curSelected)
			{
				case "input" :  StandardInput.InputSelect(); break;
				case "build-dirs": DirBuilder.DirBuild(); break;
				case "exit" : Console.WriteLine("Exiting program..."); Thread.Sleep(3000); break;
			}
		}
	}
}
