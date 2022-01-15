using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Base.Sources.UtilCommands;

namespace Main.Base.Program
{
    public class Base_Mode
    {
        public void BaseMode(bool showInfo)
        {
            CmdHelp HelpCmd = new CmdHelp();
            CmdList ListCmd = new CmdList();
            CmdInput InputCmd = new CmdInput();
            CmdInputList InputListCmd = new CmdInputList();
            var curCmd = "";

            if (showInfo) {
                Console.WriteLine("\nNocticOS (Base) - Version 1.0\nType, '-h' for help.");
            }

            Console.Write("> ");
            curCmd = Console.ReadLine();

            switch (curCmd)
            {
                case "-h" : HelpCmd.HelpCommand(); break;
                case "-l" : ListCmd.ExecCmdList(); break;
                case "-input" : InputListCmd.ExecInputList(true); break;
                case "-input -ls" : InputListCmd.ExecInputList(false); break;
                case "-input -str" : InputCmd.InputStr(); break;
                case "-input -int" : InputCmd.InputInt(); break;
                case "-input -fl" : InputCmd.InputFloat(); break;
                case "-input -dou" :  InputCmd.InputDouble(); break;
            }
        }
    }
}