using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;
using NocticOS.Settings;

namespace NocticOS.Secrets
{
	public class FunIsInfinite
	{
		public void Open()
		{
			Program program = new Program();
			MajinCodeSwitcher majinCodeSwitcher = new MajinCodeSwitcher();
			CursorPrefs cursorPrefs = new CursorPrefs();
			string? secretCode = "";
			Console.Write("\nFun is infinite. -Majin\n");
			Console.Write("\n" + cursorPrefs.curSelectCursor);
			secretCode = Console.ReadLine();
			if (String.IsNullOrEmpty(secretCode)) {
				Throw emptyValue = new Throw();
				emptyValue.CreateThrow(
					false,
					"ev",
					"Empty value. Please try again.",
					true
				);
				program.DoReturn(false);
			} else {
				majinCodeSwitcher.CodeSwitch(secretCode);
			}
		}
	}
}
