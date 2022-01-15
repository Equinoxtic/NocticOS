using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO.Program;
using Main.Base.Program;

namespace NocticOS
{
    public class ProgramReturn
    {
        public void DoReturn()
		{
			ISO_Mode IsoMain = new ISO_Mode();
			Base_Mode baseMain = new Base_Mode();
			var curMode = "";

			Console.WriteLine("\nNocticOS - Version (1.0)");
			Console.Write("Select a Mode:\n[base] Base Mode | [iso] ISO Mode\n> ");
			curMode = Console.ReadLine();

			switch (curMode)
			{
				case "base":
					baseMain.BaseMode(true);
					break;

				case "iso":
					IsoMain.IsoMode(true);
					break;
			}
		}
    }
}