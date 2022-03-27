using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Main;
using NocticOS.Source;
using NocticOS.Settings;
using NocticOS.HelpUtil;
using NocticOS.Utility;
using NocticOS.Secrets;

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
			UIConfiguration uiConfig = new UIConfiguration();
			TimeConfiguration timeConfiguration = new TimeConfiguration();
			CursorPrefs cursorPrefs = new CursorPrefs();

			// Utils
			OSInfo osInfo = new OSInfo();
			DirectoryBuilder directoryBuilder = new DirectoryBuilder();
			DateDisplay dateDisplayer = new DateDisplay();
			StandardMath standardMath = new StandardMath();
			ClearScreen clearScreen = new ClearScreen();
			OSExit osExit = new OSExit();
			LinkOpener linkOpener = new LinkOpener();

			// States /  Classes
			MainConsole mainConsole = new MainConsole();
			InputState standardInput = new InputState();
			MathState mathState = new MathState();
			CreationState creationState = new CreationState();
			
			// Secrets
			SecretSwitcher secretSwitcher = new SecretSwitcher();
			TheFitnessGramPacerTest fitnessGramPacerTest = new TheFitnessGramPacerTest();

			switch (curCmd)
			{
				case "help" : helpState.OpenState(); break;

				case "date" : dateDisplayHelp.OpenHelp(true); break;
				case "date -help" : dateDisplayHelp.OpenHelp(false); break;
				case "date -t" or "date -time" : dateDisplayer.DisplaySwitch("time"); break;
				case "date -d" or "date -day" : dateDisplayer.DisplaySwitch("date"); break;
				case "date -m" or "date -month" : dateDisplayer.DisplaySwitch("month"); break;
				case "date -y" or "date -year" : dateDisplayer.DisplaySwitch("year"); break;
				case "date -cur" or "date -current" : dateDisplayer.DisplaySwitch("time-and-date"); break;

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
				case "config -sel" or "config -select" : osConfig.Open(); break;
				case "config -bg" or "bg -config" : osConfig.SwitchConfigState("bg"); break;
				case "config -fg" or "fg -config" : osConfig.SwitchConfigState("fg"); break;
				case "config -cursor" or "cursor -config" : osConfig.SwitchConfigState("cursor"); break;
				case "config -cursor /default" or "cursor -config /default" : cursorPrefs.SwitchCursorConfig("default"); break;
				case "config -cursor /selection" or "cursor -config /selection" : cursorPrefs.SwitchCursorConfig("selection"); break;
				case "config -interface" or "interface -config" : uiConfig.ConfigPrompt(); break;
				case "config -interface /time" or "interface -config /time" : uiConfig.SwitchConfigState("show-time"); break;
				case "config -interface /dnver" or "interface -config /dnver" : uiConfig.SwitchConfigState("show-dotnet-version"); break;
				case "config -interface /osver" or "interface -config /osver" : uiConfig.SwitchConfigState("show-os-version"); break;
				case "config -time" or "time -config" : timeConfiguration.TimeConfigPrompt(); break;
				
				case "open -noctic" or "open -os" or "open -home": mainConsole.OpenConsole(); break;

				case "os-info" or "sys-info" : osInfo.ShowInfo(); break;
				case "os-info /version" or "sys-info /version" : osInfo.InfoSwitch("version"); break;
				case "os-info /os-build" or "sys-info /os-build" : osInfo.InfoSwitch("os-build"); break;
				case "os-info /cur-os" or "sys-info /cur-os" : osInfo.InfoSwitch("cur-os"); break;
				case "os-info /dotnet-version" or "sys-info /dotnet-version" : osInfo.InfoSwitch("dotnet-version"); break;

				case "clear" or "cls" : clearScreen.ScreenClear(true);  break;

				case "repo" or "os-repo" : linkOpener.OpenLink("https://github.com/Equinoxtic/NocticOS"); break;


				/* Commenting this for now, until April Fools arrives :trollface:
				case "evpx-ebyy" : linkOpener.OpenLink("https://www.youtube.com/watch?v=dQw4w9WgXcQ"); break;
				case "evpxgebanhg-va-gur-bprna" : linkOpener.OpenLink("https://www.youtube.com/watch?v=1w432mbp2jQ"); break;
				case "me-when" : linkOpener.OpenLink("https://www.youtube.com/watch?v=Fakw7Rxa1PI"); break;
				case "6D 75 73 69 63 2D 64 69 73 63 2D 72 65 61 63 74 69 6F 6E" : linkOpener.OpenLink("https://www.youtube.com/watch?v=cwem1LLlTPI"); break;
				case "consume" : linkOpener.OpenLink("https://www.youtube.com/watch?v=Q7o4Hn1vSPw"); break;
				case "heheheha" : linkOpener.OpenLink("https://www.youtube.com/watch?v=Sag4AGymNr0"); break;
				case "fard" : linkOpener.OpenLink("https://www.youtube.com/watch?v=Qi1KebO4bzc"); break;
				case "somebody-scream" : linkOpener.OpenLink("https://www.youtube.com/watch?v=FnEnQzyXSFk"); break;
				case "secret /infinite" : secretSwitcher.SecretSwitch("infinite"); break;
				case "secret /pacer-test" : fitnessGramPacerTest.Description(); break;
				*/

				case "exit" or "out" or "close" : osExit.Exit(true); break;
			}
		}
	}
}