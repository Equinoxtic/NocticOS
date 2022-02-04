using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.HelpUtil
{
    public class CreationHelp
    {
        public void OpenHelp(bool isMissingParams)
        {
            ProgramReturn Program = new ProgramReturn();

            string[] creationFlags = {
                "-sel",
                "-obj",
                "-func",
                "-class"
            };

            string[] creationDescs = {
                " - Standard Creation selection, gives you the options for creating a custom object, function and class.",
                " - Create a Custom Object, input it's own name and type.",
                " - Create a Custom Function, input it's own name and allows you to select a code preset to run.",
                " - Create a Custom Class, input it's own name and it also allows you to store objects within it.",
            };

            if (isMissingParams) {
                Console.Write("\nMissing parameters, please enter the following:\n");
            }

            Console.Write("\n");

            for (int i = 0; i < 4; i++) {
                if (isMissingParams) {
                    Console.Write("create " + creationFlags[i] + "\n");
                } else {
                    Console.Write("create " + creationFlags[i] + creationDescs[i] + "\n");
                }
            }
        
            Program.DoReturn(false);
        }
    }
}