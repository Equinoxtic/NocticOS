using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Main;
using NocticOS.Source;
using NocticOS.Settings;
using NocticOS.HelpUtil;
using NocticOS.Utility;

namespace NocticOS.Lib
{
    public class CommandSwitch
    {
        public void OpenCommand(string curCmd)
        {
			// Help things
			ConfigHelp configHelp = new ConfigHelp();
            BuildHelp buildHelp = new BuildHelp();
			HelpState helpState = new HelpState();
			DateDisplayHelp dateDisplayHelp = new DateDisplayHelp();
			MathHelp mathHelp = new MathHelp();
			InputHelp inputHelp = new InputHelp();
			CreationHelp creationHelp = new CreationHelp();

			// Settings
			OSConfiguration osConfig = new OSConfiguration();
			CursorPrefs cursorPrefs = new CursorPrefs();

			// Utils
			OSInfo osInfo = new OSInfo();
			DirectoryBuilder directoryBuilder = new DirectoryBuilder();
			DateDisplay dateDisplayer = new DateDisplay();
			StandardMath standardMath = new StandardMath();

			// States /  Classes
			MainConsole mainConsole = new MainConsole();
			InputState standardInput = new InputState();
			MathState mathState = new MathState();
			CreationState creationState = new CreationState();

            switch (curCmd)
			{
				case "help" : helpState.OpenState(); break;

				case "day" : dateDisplayHelp.OpenHelp(true); break;
				case "day -help" : dateDisplayHelp.OpenHelp(false); break;
				case "day -t" or "day -time" : dateDisplayer.DisplayTime(); break;
				case "day -d" or "day -day" : dateDisplayer.DisplayDate(); break;
				case "day -cur" or "day -current" : dateDisplayer.DisplayTimeAndDate(); break;

				case "input" : inputHelp.OpenHelp(true); break;
				case "input -help" : inputHelp.OpenHelp(false); break;
				case "input -sel" or "input -select" : standardInput.InputSelect(); break;
				case "input -str" or "input -string" : standardInput.InputSwitch("str"); break;
				case "input -flt" or "input -float" : standardInput.InputSwitch("flt"); break;
				case "input -int" or "input -integer" : standardInput.InputSwitch("int"); break;
				case "input -dbl" or "uboyt -double" : standardInput.InputSwitch("dbl"); break;

				case "math" : mathHelp.OpenHelp(true); break;
				case "math -help" : mathHelp.OpenHelp(false); break;
				case "math -new" : mathState.OpenState(); break;
				case "math -add" : standardMath.NocticMath("add", true); break;
				case "math -subtract" : standardMath.NocticMath("subtract", true); break;
				case "math -multiply" : standardMath.NocticMath("multiply", true); break;
				case "math -divide" : standardMath.NocticMath("divide", true); break;

				case "create" : creationHelp.OpenHelp(true); break;
				case "create -help" : creationHelp.OpenHelp(false); break;
				case "create -sel" or "create -select" : creationState.OpenState(); break;
				case "create -obj" or "create -object" : creationState.CreationSwitch("obj"); break;
				case "create -func" or "create -function" : creationState.CreationSwitch("func"); break;
				case "create -class" : creationState.CreationSwitch("class"); break;
				case "create -struct" or "create -structure" : creationState.CreationSwitch("struct"); break;
				case "create -inface" or "create -interface" : creationState.CreationSwitch("inface"); break;

				case "build" : buildHelp.OpenHelp(true); break;
				case "build -help" : buildHelp.OpenHelp(false); break;
				case "build -dirs" : directoryBuilder.DirBuild(); break;

				case "config" : configHelp.OpenHelp(true); break;
				case "config -help" : configHelp.OpenHelp(false); break;
				case "config -sel" or "config -select" : osConfig.Open(false); break;
				case "config -bg" or "bg -config" : osConfig.SwitchConfigState("bg"); break;
				case "config -fg" or "fg -config" : osConfig.SwitchConfigState("fg"); break;
				case "config -cursor" or "cursor -config" : osConfig.SwitchConfigState("cursor"); break;
				case "config -cursor /default" or "cursor -config /default" : cursorPrefs.SwitchCursorConfig("default"); break;
				case "config -cursor /selection" or "cursor -config /selection" : cursorPrefs.SwitchCursorConfig("selection"); break;

				case "open -noctic" or "open -os" or "open -home": mainConsole.OpenConsole(); break;

				case "os-info" or "sys-info" : osInfo.ShowInfo(); break;

				case "exit" or "out" or "close" : Console.WriteLine("\nExiting program...\n"); Thread.Sleep(3000); break;
			}
        }
    }
}