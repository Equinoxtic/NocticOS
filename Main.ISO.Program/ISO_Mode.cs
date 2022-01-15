using System;
using System.Linq;
using System.Threading.Tasks;
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
                case ".input" : InputListForIso.InputList(); break;
                case ".input -str" : inputForISO.InputStr(); break;
                case ".input -int" : inputForISO.InputInt(); break;
                case ".input -fl" : inputForISO.InputFloat(); break;
                case ".input -dou" : inputForISO.InputDouble(); break;
            }
        }
    }
}