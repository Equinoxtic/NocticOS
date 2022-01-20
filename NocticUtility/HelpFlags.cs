using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO;

namespace NocticOS.NocticUtility
{
    public class HelpFlags
    {
        public void DisplayFlags()
        {
            string[] flags = {
                "-m <command>",
                "-i <command>",
                "-b <command>"
            };

            string[] descs = {
                " : NocticOS flag.",
                " : ISO Mode flag.",
                " : Base Mode flag."
            };
        }
    }
}