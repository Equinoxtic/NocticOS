using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.Source
{
    public class FunctionCodePresets
    {
        public void CodePresetSwitch(String curCodePreset)
        {
            CustomCreation customCreation = new CustomCreation();

            switch(curCodePreset)
            {
                case "preset.print-hello-world":
                    customCreation.functionPreset = "Print, Hello World!";
                    Console.Write("\nHello World!\n");
                    break;

                case "preset.input.text":
                    customCreation.functionPreset = "Input Text";
                    break;

                case "preset.input.int":
                    customCreation.functionPreset = "Input Integer";
                    break;

                case "preset.input.float":
                    customCreation.functionPreset = "Input Float";
                    break;

                case "preset.input.double":
                    customCreation.functionPreset = "Input Double";
                    break;
            }
        }
    }
}