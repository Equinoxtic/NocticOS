using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Lib
{
    public class Throw
    {
        public string? tag;
        public string? msg;
        public bool? newLine;

        public void CreateThrow(string curtag, string curmsg, bool shouldNewLine)
        {
            if (!String.IsNullOrEmpty(curtag) || !String.IsNullOrEmpty(curmsg)) {
                if (shouldNewLine) {
                    Console.Write("\n");
                }
                Console.Write(msg + "\n");
            } else {
                Console.Write("\nERROR: Tag or Message is MISSING.");
            }
        }

        public void DoThrow()
        {
            if (newLine == true) {
                Console.Write("\n");
            }
            Console.Write(msg + "\n");
        }
    }
}