using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS;
using NocticOS.ISO.Sources.Utility;
using NocticOS.ISO.Sources.Creation;

namespace Main.ISO
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
            ISO_ObjectCreation IsoObjCreate = new ISO_ObjectCreation();
            ISO_CreateList IsoCreateList = new ISO_CreateList();

            var curCmd = "";

            if (showInfo) {
                Console.WriteLine("\nNocticOS (ISO) - Version 1.1.4\nType '.h' for help.");
            }

            Console.Write("> ");
            curCmd = Console.ReadLine();

            switch (curCmd)
            {
                // ISO Commands
                case ".h" : IsoHelp.IsoHelpCmd(true); break;
                case ".ls" : IsoHelp.IsoHelpCmd(false); break;

                // Input Commands
                case ".input" : InputListForIso.InputList(true); break;
                case ".input -ls" : InputListForIso.InputList(false); break;
                case ".input -str" : inputForISO.InputStr(true); break;
                case ".input -int" : inputForISO.InputInt(true); break;
                case ".input -fld" : inputForISO.InputDouble(true); break;

                // Math Commands
                case ".math" : MathListForIso.ExecMathList(true); break;
                case ".math -ls" : MathListForIso.ExecMathList(false); break;
                case ".math -init" : MathForIso.IsoMath("", true); break;
                case ".math -add" : MathForIso.IsoMath(".math -add", false); break;
                case ".math -subtract" : MathForIso.IsoMath(".math -subtract", false); break;
                case ".math -multiply" : MathForIso.IsoMath(".math -multiply", false); break;
                case ".math -divide" : MathForIso.IsoMath(".math -divide", false); break;

                // Creation Commands
                case ".create" : IsoCreateList.ExecCreateList(true); break;
                case ".create -ls" : IsoCreateList.ExecCreateList(false); break;
                case ".create -obj" : IsoObjCreate.ObjectCreator(); break;

                // Return / Exit
                case "return" : ReturnToProgram.DoReturn(true); break;
                case "exit" : Console.WriteLine("Exiting Program..."); Thread.Sleep(3000); break;
            }
        }
    }
}