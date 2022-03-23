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
            "Current OS: " + Environment.OSVersion.ToString(),
            ".NET Version: " + Environment.Version.ToString()
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

        public void InfoSwitch(string curInfo) {
            Program program = new Program();
            Console.Write("\n");
            switch(curInfo) {
                case "version":
                    Console.Write(infoShit[1]);
                    break;
                case "os-build":
                    Console.Write(infoShit[2]);
                    break;
                case "cur-os":
                    Console.Write(infoShit[3]);
                    break;
                case "dotnet-version":
                    Console.Write(infoShit[4]);
                    break;
            }
            Console.Write("\n");
            program.DoReturn(false);
        }
    }
}