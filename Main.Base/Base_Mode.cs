using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS;
using NocticOS.Base.Sources.UtilCommands;

namespace Main.Base
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
                Console.WriteLine("\nNocticOS (Base) - Version 1.1.4\nType, '-h' for help.");
            }

            Console.Write("> ");
            curCmd = Console.ReadLine();

            switch (curCmd)
            {
                // Base Commands
                case "-h" : HelpCmd.HelpCommand(true); break;
                case "-ls" : HelpCmd.HelpCommand(false); break;

                // Input Commands
                case "-input" : InputCmd.InputLs(false, false, true, true); break;
                case "-input -ls" : InputCmd.InputLs(false, true, false, true); break;
                case "-input -str" : InputCmd.InputStr(true); break;
                case "-input -int" : InputCmd.InputInt(true); break;
                case "-input -fld" :  InputCmd.InputDouble(true); break;

                // Math Commands
                case "-math" : MathListCmd.ExecMathList(true); break;
                case "-math -ls" : MathListCmd.ExecMathList(false); break;
                case "-math -init" : MathCmd.ExecMathCmd("", true); break;
                case "-math -add" : MathCmd.ExecMathCmd("-math -add", false); break;
                case "-math -subtract" : MathCmd.ExecMathCmd("-math -subtract", false); break;
                case "-math -multiply" : MathCmd.ExecMathCmd("-math -multiply", false); break;
                case "-math -divide" : MathCmd.ExecMathCmd("-math -divide", false); break;

                // Return / Exit
                case "return" : ReturnToProgram.DoReturn(true); break;
                case "exit" : Console.WriteLine("Exiting Program..."); Thread.Sleep(3000); break;
            }
        }
    }
}