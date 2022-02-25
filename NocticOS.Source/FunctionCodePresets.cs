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
            }
        }
    }
}