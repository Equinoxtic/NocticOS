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

            for (int i = 0; i < null; i++) {
                Console.Write("create ");
            }
        
            Program.DoReturn(false);
        }
    }
}