using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS;
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
            CmdMath MathCmd = new CmdMath();
            CmdMathList MathListCmd = new CmdMathList();
            ProgramReturn ReturnToProgram = new ProgramReturn();

            var curCmd = "";

            if (showInfo) {
                Console.WriteLine("\nNocticOS (Base) - Version 1.0\nType, '-h' for help.");
            }

            Console.Write("> ");
            curCmd = Console.ReadLine();

            switch (curCmd)
            {
                case "-h" : HelpCmd.HelpCommand(); break;
                case "-ls" : ListCmd.ExecCmdList(); break;
                case "-input" : InputListCmd.ExecInputList(true); break;
                case "-input -ls" : InputListCmd.ExecInputList(false); break;
                case "-input -str" : InputCmd.InputStr(true); break;
                case "-input -int" : InputCmd.InputInt(true); break;
                case "-input -fld" :  InputCmd.InputDouble(true); break;
                case "-math" : MathListCmd.ExecMathList(true); break;
                case "-math -ls" : MathListCmd.ExecMathList(false); break;
                case "-math -init" : MathCmd.ExecMathCmd("", true); break;
                case "-math -add" : MathCmd.ExecMathCmd("-math -add", false); break;
                case "-math -subtract" : MathCmd.ExecMathCmd("-math -subtract", false); break;
                case "-math -multiply" : MathCmd.ExecMathCmd("-math -multiply", false); break;
                case "-math -divide" : MathCmd.ExecMathCmd("-math -divide", false); break;
                case "return" : ReturnToProgram.DoReturn(true); break;
                case "exit" : Console.WriteLine("Exiting Program..."); break;
            }
        }
    }
}