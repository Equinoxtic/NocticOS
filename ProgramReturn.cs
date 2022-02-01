using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Main;
using NocticOS.Source;
using NocticOS.HelpUtil;
using NocticOS.Utility;

namespace NocticOS
{
    public class ProgramReturn
    {
        public void DoReturn(bool showInfo)
		{
			DirectoryBuilder DirBuilder = new DirectoryBuilder();

			// Help Utils
			HelpState helpState = new HelpState();

			// Utils
			StandardMath standardMath = new StandardMath();

			// States /  Classes
			InputState StandardInput = new InputState();
			MathState mathState = new MathState();

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

				case "math" : mathState.OpenState(); break;
				case "math -add" : standardMath.NocticMath("add", true); break;
				case "math -subtract" : standardMath.NocticMath("subtract", true); break;
				case "math -multiply" : standardMath.NocticMath("multiply", true); break;
				case "math -divide" : standardMath.NocticMath("divide", true); break;

				case "build-dirs": DirBuilder.DirBuild(); break;

				case "exit" : Console.WriteLine("Exiting program...\n"); Thread.Sleep(3000); break;
			}
		}
    }
}