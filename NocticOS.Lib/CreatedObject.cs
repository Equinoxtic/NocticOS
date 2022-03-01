using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Lib
{
	public class CreatedObject
	{
		public string? name;
		public string? tag;
		public string? type;
		public string? curValue;
		public void CreateObject(string? curName, string? curTag, string? curType, bool codeExec)
		{
			switch(curType)
			{
				case "string":
					curType = "string";
					break;

				case "int":
					curType = "int";
					break;

				case "float":
					curType = "float";
					break;

				case "double":
					curType = "double";
					break;
			}
			var daValue = curValue;
			if (codeExec) {
				Console.Write("\nName: " + curName + "\nTag: " + curTag + "\nType: " + curType + "\nValue: " + daValue);
			}
		}
	}
}
