using System;
using System.Linq;
using System.IO;
using Main.ISO.Program;
using NocticOS.ISO.Sources.Classes.Utility;

namespace NocticOS.ISO.Sources.Classes.Creation
{
    public class ObjectCreation
    {
        public void ObjectCreator()
        {
            ISO_Mode IsoMain = new ISO_Mode();
            ISO_Input IsoIn = new ISO_Input();
            var objName = "";
            var objType = "";

            Console.Write("\nInput a name for your new object: ");
            objName = Console.ReadLine();
        }
    }
}