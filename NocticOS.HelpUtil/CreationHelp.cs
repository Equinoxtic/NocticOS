using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS.HelpUtil
{
    public class CreationHelp
    {
        // ThrowError throwError = new ThrowError();
        Throw missingParams = new Throw();

        string[] creationLs = {
            "-help - Shows information about the 'create' command.",
            "-sel - Standard Creation selection, gives you the options for creating a custom object, function and class.",
            "-obj - Create a Custom Object, input it's own name and type.",
            "-func - Create a Custom Function, input it's own name and allows you to select a code preset to run.",
            "-class - Create a Custom Class, input it's own name and it also allows you to store objects within it."
        };

        /*
        string[] creationDescs = {
            " - Shows information about the 'create' command.",
            " - Standard Creation selection, gives you the options for creating a custom object, function and class.",
            " - Create a Custom Object, input it's own name and type.",
            " - Create a Custom Function, input it's own name and allows you to select a code preset to run.",
            " - Create a Custom Class, input it's own name and it also allows you to store objects within it.",
        };
        */

        public void OpenHelp(bool isMissingParams)
        {
            ProgramReturn Program = new ProgramReturn();

            if (isMissingParams) {
                // throwError.MissingParamsThrow(true);
                missingParams.CreateThrow("mp",
                    "Missing Parameters. Please enter the following:",
                    true
                );
            }

            Console.Write("\n");

            for (int i = 0; i < creationLs.Length; i++) {
                if (isMissingParams) {
                    Console.Write("create " + creationLs[i] + "\n");
                } else {
                    Console.Write(creationLs[i] + "\n");
                }
            }
        
            Program.DoReturn(false);
        }
    }
}