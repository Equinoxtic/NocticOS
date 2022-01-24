using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO;

namespace NocticOS.ISO.Sources.Classes.Utility
{
    public class ISO_Help
    {
        public void IsoHelpCmd(bool isHelp)
        {
            ISO_Mode IsoMain = new ISO_Mode();
            
            string[] strCmdList = {
                ".h", 
                ".ls", 
                ".input <type>", 
                ".math <operation>",
                ".create <type>"
            };

            string[] strCmdDescs = {
                " - Displays information on all of the commands.",
                " - Displays the list of commands, but doesn't display the information.",
                " - Standard Input for strings, integer, floats and doubles.",
                " - Simple math with the 4 simplest operations, addition, subtraction, multiplication, and division.",
                " - Used for creating custom Objects, Functions and Classes."
            };

            if (!isHelp) {
                Console.WriteLine("\nAll Available commands for NocticOS (ISO):");
            }
            
            Console.Write("\n");
            for (int i = 0; i < 5; i++) {
                if (isHelp) {
                    Console.Write(strCmdList[i] + strCmdDescs[i] + "\n");
                } else {
                    Console.Write(strCmdList[i] + "\n");
                }
            }
            Console.Write("\n");

            IsoMain.IsoMode(false);
        }
    }
}