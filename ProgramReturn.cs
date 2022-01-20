using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO;
using Main.Base;
using NocticOS.ISO.Sources.Classes.Utility;
using NocticOS.Base.Sources.UtilCommands;
using NocticOS.NocticUtility;

namespace NocticOS
{
    public class ProgramReturn
    {
        public void DoReturn(bool showInfo)
		{
			ISO_Mode IsoMain = new ISO_Mode();
			Base_Mode baseMain = new Base_Mode();
			NocticCmdList Cmdls = new NocticCmdList();
			HelpFlags FlagsForHelp = new HelpFlags();

			ISO_Input InputForIso = new ISO_Input();
			ISO_Math MathForIso = new ISO_Math();

			CmdInput BaseInput = new CmdInput();
			CmdMath BaseMath = new CmdMath();

			var curSelected = "";

			if (showInfo) {
				Console.WriteLine("\nNocticOS - Version (1.1.4)");
				Console.Write("Type in 'help' to get started.");
			}

			Console.Write("\n> ");
			curSelected = Console.ReadLine();

			switch (curSelected)
			{
				// Help Commands
				case "help" : Cmdls.OpenCmdList(); break;
				case "help -flags" : FlagsForHelp.DisplayFlags(); break;

				// Help ISO
				case "help -i input" : InputForIso.InputLs(true, false, false, false); break;
				case "help -i math" : MathForIso.MathLs(true, false, false, false); break;
				
				// Help Base
				case "help -b input" : BaseInput.InputLs(true, false, false, false); break;
				case "help -b math" : BaseMath.MathLs(true, false, false, false); break;

				// Main Commands
				case "iso" : IsoMain.IsoMode(true); break;
				case "base" : baseMain.BaseMode(true); break;
				case "exit" : Console.WriteLine("Exiting program..."); Thread.Sleep(5000); break;
			}
		}
    }
}