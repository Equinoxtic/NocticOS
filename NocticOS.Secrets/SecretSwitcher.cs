using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS.Secrets
{
	public class SecretSwitcher
	{
		FunIsInfinite funIsInfinite = new FunIsInfinite();
		public void SecretSwitch(string? secret = "")
		{
			Program program = new Program();
			if (String.IsNullOrEmpty(secret)) {
				Throw emptyValue = new Throw();
				emptyValue.CreateThrow(
					false,
					"ev",
					"Empty value. Please try again.",
					true
				);
				program.DoReturn(false);
			} else {
				GoToSecret(secret);
			}
		}

		void GoToSecret(string? a) {
			switch(a) {
				case "infinite":
					funIsInfinite.Open();
					break;
			}
		}
	}
}