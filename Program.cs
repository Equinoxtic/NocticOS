using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS
{
	class Program
	{
		public static void Main(String[] args)
		{
			var curDir = @"C:\NocticOS";

			string[] createDirs = {
				@"C:\NocticOS\Objects",
				@"C:\NocticOS\Functions",
				@"C:\NocticOS\Classes",
				@"C:\NocticOS\Data"
			};

			System.IO.Directory.CreateDirectory(curDir);
			
			if (System.IO.Directory.Exists(curDir)) {
				for (int i = 0; i < 3; i++) {
					System.IO.Directory.CreateDirectory(createDirs[i]);
				}
			}

			var curSelected = "";
			
			Console.WriteLine("\nNocticOS - Version (1.1.4)");
			Console.Write("Type in 'help' to get started.");
			Console.Write("\n> ");
			curSelected = Console.ReadLine();

			switch (curSelected)
			{
				case "exit" : Console.WriteLine("Exiting program..."); Thread.Sleep(3000); break;
			}
		}
	}
}
