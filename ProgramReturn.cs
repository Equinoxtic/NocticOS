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
			BuildHelp buildHelp = new BuildHelp();
			HelpState helpState = new HelpState();
			MathHelp mathHelp = new MathHelp();
			InputHelp inputHelp = new InputHelp();

			// Utils
			DirectoryBuilder DirBuilder = new DirectoryBuilder();
			OSBuilder oSBuilder = new OSBuilder();
			DesktopEnviromentBuilder deBuilder = new DesktopEnviromentBuilder();
			StandardMath standardMath = new StandardMath();

			// States /  Classes
			InputState StandardInput = new InputState();
			MathState mathState = new MathState();
			CreationState creationState = new CreationState();

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

				case "create -sel" : creationState.OpenState(); break;

				case "build" : buildHelp.OpenHelp(true); break;
				case "build -help" : buildHelp.OpenHelp(false); break;
				case "build -dirs" : DirBuilder.DirBuild(); break;
				case "build -os" : oSBuilder.BuildOS(); break;
				case "build -de" : deBuilder.DEBuild(); break;

				case "exit" : Console.WriteLine("\nExiting program...\n"); Thread.Sleep(3000); break;
			}
		}
    }
}