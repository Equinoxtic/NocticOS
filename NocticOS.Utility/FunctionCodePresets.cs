using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.Utility
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
                    break;

                case "preset.input.text":
                    customCreation.functionPreset = "Input Text / String";
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

            Console.Write("\nSelected Code Preset: " + customCreation.functionPreset);

            switch(customCreation.functionPreset)
            {
                case "Print, Hello World!":
                    Console.Write("\nHello World!\n");
                    break;

                case "Input Text / String":
                    standardInput.InputStr(true, false);
                    break;

                case "Input Integer":
                    standardInput.InputInt(true, false);
                    break;
                
                case "Input Float":
                    standardInput.InputFloat(true, false);
                    break;

                case "Input Double":
                    standardInput.InputDouble(true, false);
                    break;
            }
        }
    }
}