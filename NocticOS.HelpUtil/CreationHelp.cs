using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.HelpUtil
{
    public class CreationHelp
    {
        ThrowError throwError = new ThrowError();
        public void OpenHelp(bool isMissingParams)
        {
            ProgramReturn Program = new ProgramReturn();

            string[] creationFlags = {
                "-help",
                "-sel",
                "-obj",
                "-func",
                "-class"
            };

            string[] creationDescs = {
                " - Shows information about the 'create' command.",
                " - Standard Creation selection, gives you the options for creating a custom object, function and class.",
                " - Create a Custom Object, input it's own name and type.",
                " - Create a Custom Function, input it's own name and allows you to select a code preset to run.",
                " - Create a Custom Class, input it's own name and it also allows you to store objects within it.",
            };

            if (isMissingParams) {
                throwError.MissingParamsThrow(true);
            }

            Console.Write("\n");

            for (int i = 0; i < 5; i++) {
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