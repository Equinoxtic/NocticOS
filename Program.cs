using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.NocticISO.Sources;
using NocticOS.NocticBase.Sources;

namespace NocticOS
{
	class Program
	{
		public static void Main(String[] args)
		{
			ISO Iso = new ISO();
			Base Nbase = new Base();
			var curMode = "";

			Console.WriteLine("\nNocticOS - Version (1.0)");
			Console.Write("Select a Mode:\n[base] Base Mode | [iso] ISO Mode\n> ");
			curMode = Console.ReadLine();

			switch (curMode)
			{
				case "base":
					Nbase.BaseMode(true);
					break;

				case "iso":
					Iso.IsoMode(true);
					break;
			}
		}
	}
}
