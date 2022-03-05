using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Main;
using NocticOS.Source;
using NocticOS.HelpUtil;
using NocticOS.Utility;

namespace NocticOS.Lib
{
    public class CommandSwitch
    {
        public void OpenCommand(string curCmd)
        {
            BuildHelp buildHelp = new BuildHelp();
			HelpState helpState = new HelpState();
			DateDisplayHelp dateDisplayHelp = new DateDisplayHelp();
			MathHelp mathHelp = new MathHelp();
			InputHelp inputHelp = new InputHelp();
			CreationHelp creationHelp = new CreationHelp();

			// Utils
			DirectoryBuilder directoryBuilder = new DirectoryBuilder();
			OSBuilder oSBuilder = new OSBuilder();
			DesktopEnviromentBuilder deBuilder = new DesktopEnviromentBuilder();
			DateDisplay dateDisplayer = new DateDisplay();
			StandardMath standardMath = new StandardMath();

			// States /  Classes
			InputState standardInput = new InputState();
			MathState mathState = new MathState();
			CreationState creationState = new CreationState();

            switch (curCmd)
			{
				case "help" : helpState.OpenState(); break;

				case "day" : dateDisplayHelp.OpenHelp(true); break;
				case "day -help" : dateDisplayHelp.OpenHelp(false); break;
				case "day -t" : dateDisplayer.DisplayTime(); break;
				case "day -d" : dateDisplayer.DisplayDate(); break;
				case "day -cur" : dateDisplayer.DisplayTimeAndDate(); break;

				case "input" : inputHelp.OpenHelp(true); break;
				case "input -help" : inputHelp.OpenHelp(false); break;
				case "input -sel" : standardInput.InputSelect(); break;
				case "input -str" : standardInput.InputSwitch("str"); break;
				case "input -flt" : standardInput.InputSwitch("flt"); break;
				case "input -int" : standardInput.InputSwitch("int"); break;
				case "input -dbl" : standardInput.InputSwitch("dbl"); break;

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
				case "create -struct" : creationState.CreationSwitch("struct"); break;
				case "create -inface" : creationState.CreationSwitch("inface"); break;

				case "build" : buildHelp.OpenHelp(true); break;
				case "build -help" : buildHelp.OpenHelp(false); break;
				case "build -dirs" : directoryBuilder.DirBuild(); break;
				case "build -os" : oSBuilder.BuildOS(); break;
				case "build -de" : deBuilder.DEBuild(); break;

				case "exit" : Console.WriteLine("\nExiting program...\n"); Thread.Sleep(3000); break;
			}
        }
    }
}