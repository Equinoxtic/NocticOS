using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS;
using NocticOS.ISO.Sources.Classes.Utility;

namespace Main.ISO.Program
{
    public class ISO_Mode
    {
        public void IsoMode(bool showInfo)
        {
            ISO_Help IsoHelp = new ISO_Help();
            ISO_CmdList IsoList = new ISO_CmdList();
            ISO_Input inputForISO = new ISO_Input();
            ISO_InputList InputListForIso = new ISO_InputList();
            ISO_Math MathForIso = new ISO_Math();
            ISO_MathList MathListForIso = new ISO_MathList();
            ProgramReturn ReturnToProgram = new ProgramReturn();

            var curCmd = "";

            if (showInfo) {
                Console.WriteLine("\nNocticOS (ISO) - Version 1.0\nType '.h' for help.");
            }
            Console.Write("> ");
            curCmd = Console.ReadLine();

            switch (curCmd)
            {
                case ".h" : IsoHelp.IsoHelpCmd(); break;
                case ".l" : IsoList.ExecCmdList(); break;
                case ".input" : InputListForIso.InputList(true); break;
                case ".input -ls" : InputListForIso.InputList(false); break;
                case ".input -str" : inputForISO.InputStr(); break;
                case ".input -int" : inputForISO.InputInt(); break;
                case ".input -fld" : inputForISO.InputDouble(); break;
                case ".math" : MathListForIso.ExecMathList(true); break;
                case ".math -ls" : MathListForIso.ExecMathList(false); break;
                case ".math -init" : MathForIso.IsoMath("", true); break;
                case ".math -add" : MathForIso.IsoMath(".math -add", false); break;
                case ".math -subtract" : MathForIso.IsoMath(".math -subtract", false); break;
                case ".math -multiply" : MathForIso.IsoMath(".math -multiply", false); break;
                case ".math -divide" : MathForIso.IsoMath(".math -divide", false); break;
                case "return" : ReturnToProgram.DoReturn(); break;
            }
        }
    }
}