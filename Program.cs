using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO;
using Main.Base;
using NocticOS.NocticUtility;
using NocticOS.ISO.Sources.Utility;
using NocticOS.ISO.Sources.Creation;
using NocticOS.Base.Sources.UtilCommands;
using NocticOS.Base.Sources.CreationCommands;

namespace NocticOS
{
	class Program
	{
		public static void Main(String[] args)
		{
			ISO_Mode IsoMain = new ISO_Mode();
			Base_Mode baseMain = new Base_Mode();
			NocticCmdList Cmdls = new NocticCmdList();
			HelpFlags FlagsForHelp = new HelpFlags();

			ISO_Input InputForIso = new ISO_Input();
			ISO_Math MathForIso = new ISO_Math();
			ISO_ObjectCreation ISOCreation = new ISO_ObjectCreation();

			CmdInput BaseInput = new CmdInput();
			CmdMath BaseMath = new CmdMath();
			CmdObjectCreation BaseObjCreation = new CmdObjectCreation();

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
				// Help Commands
				case "help" : Cmdls.OpenCmdList(); break;
				case "help -flags" : FlagsForHelp.DisplayFlags(); break;
				case "help iso" : break;

				// Help ISO
				case "help -i input" : InputForIso.InputLs(true, false, false, false); break;
				case "help -i math" : MathForIso.MathLs(true, false, false,false); break;
				case "help -i create" : ISOCreation.CreationList(true, false, false, false); break;

				// Help Base
				case "help -b input" : BaseInput.InputLs(true, false, false, false); break;
				case "help -b math" : BaseMath.MathLs(true, false, false, false); break;
				case "help -b create" : BaseObjCreation.CreationList(true, false, false, false); break;

				// Main Commands
				case "iso" : IsoMain.IsoMode(true); break;
				case "base" : baseMain.BaseMode(true); break;
				case "exit" : Console.WriteLine("Exiting program..."); Thread.Sleep(3000); break;
			}
		}
	}
}
