using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Main;
using NocticOS.Source;
using NocticOS.HelpUtil;

namespace NocticOS
{
    public class ProgramReturn
    {
        public void DoReturn(bool showInfo)
		{
			DirectoryBuilder DirBuilder = new DirectoryBuilder();
			HelpState helpState = new HelpState();
			InputState StandardInput = new InputState();
			MathState StandardMath = new MathState();

			var curSelected = "";

			if (showInfo) {
				Console.WriteLine("\nNocticOS - Version (1.1.4)");
				Console.Write("Type in 'help' to get started.");
			}

			Console.Write("\n> ");
			curSelected = Console.ReadLine();

			switch (curSelected)
			{
				case "help" : helpState.OpenState(); break;
				case "input" :  StandardInput.InputSelect(); break;
				case "math" : StandardMath.OpenState(); break;
				case "build-dirs": DirBuilder.DirBuild(); break;
				case "exit" : Console.WriteLine("Exiting program..."); Thread.Sleep(3000); break;
			}
		}
    }
}