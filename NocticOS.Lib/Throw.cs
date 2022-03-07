using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Lib
{
	public class Throw
	{
		public string? tag;
		public string? msg;
		public bool? newLine;

		public void CreateThrow(bool setaswip, string? curtag = "", string? curmsg = "", bool shouldNewLine = false, string? wipkey = "") {
			if (!setaswip) {
				if (!String.IsNullOrEmpty(curtag) || !String.IsNullOrEmpty(curmsg)) {
					if (shouldNewLine) {
						Console.Write("\n");
					}
					Console.Write(curmsg + "\n");
				}
				else {
					Console.Write("\nERROR: Tag or Message is MISSING.");
				}
			} else {
				if (!String.IsNullOrEmpty(wipkey)) {
					if (shouldNewLine) {
						Console.Write("\n");
					}
					Console.Write("This " + wipkey + " is still a WIP.\n");
				}
			}
		}

		public void DoThrow() {
			if (newLine == true) {
				Console.Write("\n");
			}
			Console.Write(msg + "\n");
		}
	}
}