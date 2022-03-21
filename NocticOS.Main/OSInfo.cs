using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Main
{
    public class OSInfo
    {
        string[] infoShit = {
            "========== NocticOS ==========",
            "Version: 1.1.5 - BETA",
            "OS-Build: Vertigo", // Builds will undergo a cryptic word.
            ".NET Version: " + Environment.Version.ToString(),
        };

        public void ShowInfo()
        {
            Program program = new Program();
            Console.Write("\n");
            for (int i = 0; i < infoShit.Length; i++) {
                Console.Write(infoShit[i] + "\n");
            }
            program.DoReturn(false);
        }
    }
}