using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO;

namespace NocticOS.ISO.Sources.Classes.Utility
{
    public class ISO_Help
    {
        public void IsoHelpCmd()
        {
            ISO_Mode IsoMain = new ISO_Mode();
            
            string[] strCmdList = {
                ".h", 
                ".ls", 
                ".input", 
                ".math",
                ".create"
            };

            string[] strCmdDescs = {
                " - Displays information on all of the commands.",
                " - Displays the list of commands, but doesn't display the information.",
                " <type> - Standard Input for strings, integer, floats and doubles.",
                " <operation> - Simple math with the 4 simplest operations, addition, subtraction, multiplication, and division.",
                " <type> - Used for creating custom Objects, Functions and Classes."
            };
            
            Console.Write("\n");
            for (int i = 0; i < 5; i++) {
                Console.Write(strCmdList[i] + strCmdDescs[i] + "\n");
            }
            Console.Write("\n");

            IsoMain.IsoMode(false);
        }
    }
}