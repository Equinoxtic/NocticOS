using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;
using NocticOS.Main;

namespace NocticOS.Secrets
{
	public class MajinCodeSwitcher
	{
		public void CodeSwitch(string? code) {
			Program program = new Program();
			if (String.IsNullOrEmpty(code)) {
				Throw nullCode = new Throw();
				nullCode.CreateThrow(
					false,
					"ev",
					"Code is NULL. Please try this process again, later.",
					true
				);
				program.DoReturn(false);
			} else {
				GoToCode(code);
			}
		}

		void GoToCode(string? theCode) {
			Program program = new Program();
			LinkOpener linkOpener = new LinkOpener();
			switch(theCode) {
				case "0707":
					linkOpener.OpenLink("https://www.youtube.com/watch?v=9kN8BQ6pUfY");
					break;
				case "back":
					program.DoReturn(false);
					break;
			}
			program.DoReturn(false);
		}
	}
}
