/*
Every creation command is still in BETA
The creation commands will be different once fully released.
The current creation command that is available for use right now is "ObjectCreation".
Please enjoy the OS whilst I work on making changes on the creation commands.
--- Equinoxtic
*/

using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;
using NocticOS.Settings;
using NocticOS.Lib;

namespace NocticOS.Source
{
    public class CreationState
    {
        CursorPrefs prefs = new CursorPrefs();
        Options createOptions = new Options();

        string[] customTypeLs = {
            "[obj] - Create a Custom Object.",
            "[func] - Create a Custom Function.",
            "[class] - Create a Custom Class.",
            "[struct] - Create a Custom Structure.",
            "[inface] - Create a Custom Interface.",
        };

        /*
        string[] customTypeDescs = {
            "Create a Custom Object.",
            "Create a Custom Function.",
            "Create a Custom Class.",
            "Create a Custom Structure.",
            "Create a Custom Interface."
        };
        */

        public void OpenState()
        {
            Program program = new Program();
            CustomCreation customCreation = new CustomCreation();

            var customType = "";

            Console.Write("\nSelect an action:\n\n");

            /*
            for (int i = 0; i < 5; i++) {
                Console.Write(customTypeTags[i] + customTypeDescs[i] + "\n");
            }
            */

            createOptions.PushOptions(customTypeLs, customTypeLs.Length);

            Console.Write("\n" + prefs.curSelectCursor);
            
            customType = Console.ReadLine();
            if (String.IsNullOrEmpty(customType)) {
                Throw emptyValue = new Throw();
                emptyValue.CreateThrow(
                    false,
                    "ev",
                    "Empty value. Please try again.",
                    true
                );
                program.DoReturn(false);
            } else {
                switch(customType)
                {
                    case "obj": customCreation.ObjectCreation(); break;
                    case "func" : customCreation.FunctionCreation(); break;
                    case "class" : customCreation.ClassCreation(); break;
                    case "struct" : customCreation.StructCreation(); break;
                    case "inface" : customCreation.InterfaceCreation(); break;
                }
            }
        }

        public void CreationSwitch(string createType)
        {
            CustomCreation customCreation = new CustomCreation();
            
            switch (createType)
            {
                case "obj" : customCreation.ObjectCreation(); break;
                case "func" : customCreation.FunctionCreation(); break;
                case "class" : customCreation.ClassCreation(); break;
                case "struct" : customCreation.ClassCreation(); break;
                case "inface" : customCreation.InterfaceCreation(); break;
            }
        }
    }
}