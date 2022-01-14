using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.NocticISO.Sources.Classes.Utility;

namespace NocticOS.Main.ISO.Program
{
    public class ISO
    {
        public void IsoMode(bool showInfo)
        {
            ISO_Help IsoHelp = new ISO_Help();
            ISO_CmdList IsoList = new ISO_CmdList();
            var curCmd = "";

            if (showInfo) {
                Console.WriteLine("\nNocticOS (ISO) - Version 1.0\nType '.h' for help.");
            }
            Console.Write("> ");
            curCmd = Console.ReadLine();

            switch (curCmd)
            {
                case ".h":
                    IsoHelp.IsoHelpCmd();
                    break;

                case ".l":
                    IsoList.ExecCmdList();
                    break;
            }
        }
    }
}