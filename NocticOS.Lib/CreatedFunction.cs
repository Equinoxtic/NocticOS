using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.Lib
{
	public class CreatedFunction
	{
		FunctionCodePresets functionCodePresets = new FunctionCodePresets();
        ThrowError throwError = new ThrowError();

		public string? name;
		public string? tag;
		public string? codePreset;
		public bool allowCodeExec;

		public void CreateFunction(string? curName, string? curTag, string? curCodePreset, bool codeExec)
		{
			if (!String.IsNullOrEmpty(curName) || !String.IsNullOrEmpty(curTag) || !String.IsNullOrEmpty(curCodePreset))
			{
				curName = name;
				curTag = tag;
				curCodePreset = codePreset;
				if (codeExec)
				{
					switch (curCodePreset)
					{
						case "preset.print-hello-world":
							functionCodePresets.CodePresetSwitch("preset.print-hello-world");
							break;

						case "preset.input.text":
							functionCodePresets.CodePresetSwitch("preset.input.text");
							break;

						case "preset.input.int":
							functionCodePresets.CodePresetSwitch("preset.input.int");
							break;

						case "preset.input.float":
							functionCodePresets.CodePresetSwitch("preset.input.float");
							break;

						case "preset.input.double":
							functionCodePresets.CodePresetSwitch("preset.input.double");
							break;
					}
				}
			} else {
                throwError.ThrowSwitch("oc", true);
            }
		}
	}
}