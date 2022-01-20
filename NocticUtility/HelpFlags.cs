using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO;

namespace NocticOS.NocticUtility
{
    public class HelpFlags
    {
        ProgramReturn ReturnToProgram = new ProgramReturn();
        public void DisplayFlags()
        {
            string[] flags = {
                "-m",
                "-i",
                "-b"
            };

            string[] descs = {
                " : NocticOS flag.",
                " : ISO Mode flag.",
                " : Base Mode flag."
            };

            Console.Write("\nCurrent Flags:\n\n");

            for (int i = 0; i < 3; i++) {
                Console.Write(flags[i] + descs[i] + "\n");
            }
            ReturnToProgram.DoReturn(false);
        }
    }
}