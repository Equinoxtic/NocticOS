using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Main;
using NocticOS.Source;
using NocticOS.HelpUtil;
using NocticOS.Utility;

namespace NocticOS
{
	class Program
	{
		public static void Main(String[] args)
		{
			// Help Utils
			BuildHelp buildHelp = new BuildHelp();
			HelpState helpState = new HelpState();
			MathHelp mathHelp = new MathHelp();
			InputHelp inputHelp = new InputHelp();
			CreationHelp creationHelp = new CreationHelp();

			// Utils
			DirectoryBuilder DirBuilder = new DirectoryBuilder();
			OSBuilder oSBuilder = new OSBuilder();
			DesktopEnviromentBuilder deBuilder = new DesktopEnviromentBuilder();
			DateDisplay DateDisplayer = new DateDisplay();
			StandardMath standardMath = new StandardMath();

			// States /  Classes
			InputState StandardInput = new InputState();
			MathState mathState = new MathState();
			CreationState creationState = new CreationState();

			var curSelected = "";
			
			Console.WriteLine("\nNocticOS - Version (1.1.4)");
			Console.Write("Type in 'help' to get started.");
			Console.Write("\n> ");
			curSelected = Console.ReadLine();

			switch (curSelected)
			{
				case "help" : helpState.OpenState(); break;

				case "time" : DateDisplayer.DisplayTime(); break;
				case "date" : DateDisplayer.DisplayDate(); break;
				case "time-and-date" : DateDisplayer.DisplayTimeAndDate(); break;

				case "input" : inputHelp.OpenHelp(true); break;
				case "input -help" : inputHelp.OpenHelp(false); break;
				case "input -sel" : StandardInput.InputSelect(); break;
				case "input -str" : StandardInput.InputSwitch("str"); break;
				case "input -flt" : StandardInput.InputSwitch("flt"); break;
				case "input -int" : StandardInput.InputSwitch("int"); break;
				case "input -dbl" : StandardInput.InputSwitch("dbl"); break;

				case "math" : mathHelp.OpenHelp(true); break;
				case "math -help" : mathHelp.OpenHelp(false); break;
				case "math -new" : mathState.OpenState(); break;
				case "math -add" : standardMath.NocticMath("add", true); break;
				case "math -subtract" : standardMath.NocticMath("subtract", true); break;
				case "math -multiply" : standardMath.NocticMath("multiply", true); break;
				case "math -divide" : standardMath.NocticMath("divide", true); break;

				case "create" : creationHelp.OpenHelp(true); break;
				case "create -help" : creationHelp.OpenHelp(false); break;
				case "create -sel" : creationState.OpenState(); break;
				case "create -obj" : creationState.CreationSwitch("obj"); break;
				case "create -func" : creationState.CreationSwitch("func"); break;
				case "create -class" : creationState.CreationSwitch("class"); break;

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
