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
			// Help Utils
			HelpState helpState = new HelpState();
			MathHelp mathHelp = new MathHelp();
			InputHelp inputHelp = new InputHelp();

			// Utils
			DirectoryBuilder DirBuilder = new DirectoryBuilder();
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
				case "help input" : helpState.HelpSwitch("input"); break;
				case "help math" : helpState.HelpSwitch("math"); break;

				case "input" : inputHelp.OpenHelp(true); break;
				case "input -help" : inputHelp.OpenHelp(false); break;
				case "input -str" : StandardInput.InputSwitch("str"); break;
				case "input -int" : StandardInput.InputSwitch("int"); break;
				case "input -dbl" : StandardInput.InputSwitch("dbl"); break;

				case "math" : mathHelp.OpenHelp(true); break;
				case "math -help" : mathHelp.OpenHelp(false); break;
				case "math -new" : mathState.OpenState(); break;
				case "math -add" : standardMath.NocticMath("add", true); break;
				case "math -subtract" : standardMath.NocticMath("subtract", true); break;
				case "math -multiply" : standardMath.NocticMath("multiply", true); break;
				case "math -divide" : standardMath.NocticMath("divide", true); break;

				case "build" : DirBuilder.DirBuild(); break;

				case "exit" : Console.WriteLine("\nExiting program...\n"); Thread.Sleep(3000); break;
			}
		}
    }
}