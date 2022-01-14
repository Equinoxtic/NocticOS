using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.NocticBase.Sources.UtilityCommands;

namespace NocticOS.Main.Base.Program
{
    public class Base
    {
        public void BaseMode(bool showInfo)
        {
            CmdHelp HelpCmd = new CmdHelp();
            CmdList ListCmd = new CmdList();
            var curCmd = "";

            if (showInfo) {
                Console.WriteLine("\nNocticOS (Base) - Version 1.0\nType, '-h' for help.");
            }

            Console.Write("> ");
            curCmd = Console.ReadLine();

            switch (curCmd)
            {
                case "-h":
                    HelpCmd.HelpCommand();
                    break;

                case "-l":
                    ListCmd.ExecCmdList();
                    break;
            }
        }
    }
}