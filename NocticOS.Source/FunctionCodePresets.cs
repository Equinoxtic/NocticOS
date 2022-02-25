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
            StandardInput standardInput = new StandardInput();

            switch(curCodePreset)
            {
                case "preset.print-hello-world":
                    customCreation.functionPreset = "Print, Hello World!";
                    Console.Write("\nHello World!\n");
                    break;

                case "preset.input.text":
                    customCreation.functionPreset = "Input Text";
                    standardInput.InputStr(true, false);
                    break;

                case "preset.input.int":
                    customCreation.functionPreset = "Input Integer";
                    standardInput.InputInt(true, false);
                    break;

                case "preset.input.float":
                    customCreation.functionPreset = "Input Float";
                    standardInput.InputFloat(true, false);
                    break;

                case "preset.input.double":
                    customCreation.functionPreset = "Input Double";
                    standardInput.InputDouble(true, false);
                    break;
            }
        }
    }
}