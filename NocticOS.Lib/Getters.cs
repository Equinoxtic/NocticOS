using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Lib
{
	public class Paths
	{
		public string Str(string? str) {
			string? theStr = str;
			if (String.IsNullOrEmpty(str)) {
				Console.Write("\nERROR: Empty / Null String.\n");
			}
			return theStr;
		}
	}
}
