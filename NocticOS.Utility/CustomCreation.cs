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
using NocticOS.Lib;

namespace NocticOS.Utility
{
    public class CustomCreation
    {
        Program program = new Program();
        // ThrowError throwError = new ThrowError();
        WIPThrow wipThrow = new WIPThrow();
        
        public void ObjectCreation()
        {
            StandardInput standardInput = new StandardInput();

            string[] objTypes = {
                "[str] String",
                "[int] Integer",
                "[flt] Float",
                "[dbl] Double"
            };

            var OBJECT_NAME = "";
            var OBJECT_TYPE = "";
            var STR_OBJECT_TYPE = "";

            Console.Write("\nInput a name for your object: ");

            OBJECT_NAME = Console.ReadLine();

            Console.Write("\nSelect an Object Type:\n");

            for (int i = 0; i < objTypes.Length; i++) {
                Console.Write(objTypes[i] + "\n");
            }

            Console.Write("~ ");

            OBJECT_TYPE = Console.ReadLine();

            switch(OBJECT_TYPE) 
            {
                case "str": 
                    STR_OBJECT_TYPE = "String";
                    standardInput.InputStr(true, false); 
                    break;

                case "flt":
                    STR_OBJECT_TYPE = "Float";
                    standardInput.InputFloat(true, false);
                    break;

                case "int": 
                    STR_OBJECT_TYPE = "Integer";
                    standardInput.InputInt(true, false); 
                    break;

                case "dbl": 
                    STR_OBJECT_TYPE = "Double";
                    standardInput.InputDouble(true, false); 
                    break;
            }

            Console.Write("Name: " + OBJECT_NAME + "\nType: " + STR_OBJECT_TYPE + "\n");

            program.DoReturn(false);
        }
        
        public string functionPreset = "";

        public void FunctionCreation()
        {
            FunctionCodePresets functionCodePresets = new FunctionCodePresets();

            string[] presetLs = {
                "[1] Print, Hello World!",
                "[2] Input Text",
                "[3] Input Integer",
                "[4] Input Float",
                "[5] Input Double"
            };

            var functionName = "";
            var strCodePreset = "";
            var functionArgLength = 0;
            var functionCodePreset = 0;

            Console.Write("\nInput the name for your function: ");
            functionName = Console.ReadLine();

            Console.Write("\nInput the amount of arguments (Maximum is 5): ");
            functionArgLength = Convert.ToInt32(Console.ReadLine());
            if (functionArgLength > 5) {
                functionArgLength = 5;
            }

            string[] functionArguments = new string[functionArgLength];

            Console.Write("\n");

            string strOrder = "";

            for (int i = 0; i < functionArgLength; i++) {
                switch (i) {
                    case 0: strOrder = "First"; break;
                    case 1: strOrder = "Second"; break;
                    case 2: strOrder = "Third"; break;
                    case 3: strOrder = "Fourth"; break;
                    case 4: strOrder = "Fifth"; break;
                }
                Console.Write(strOrder + " Argument: ");
                functionArguments[i] = Console.ReadLine();
                functionArguments.Append(functionArguments[i]);
            }

            Console.Write("\nArguments:\n");

            for (int i = 0; i < functionArgLength; i++) {
                switch (i) {
                    case 0: strOrder = "First"; break;
                    case 1: strOrder = "Second"; break;
                    case 2: strOrder = "Third"; break;
                    case 3: strOrder = "Fourth"; break;
                    case 4: strOrder = "Fifth"; break;
                }
                Console.Write(strOrder + " " + functionArguments[i] + "\n");
            }

            Console.Write("\nSelect a code preset:\n\n");

            for (int i = 0; i < presetLs.Length; i++) {
                Console.Write(presetLs[i] + "\n");
            }

            Console.Write("~ ");
            functionCodePreset = Convert.ToInt32(Console.ReadLine());

            switch(functionCodePreset)
            {
                case 1: strCodePreset = "preset.print-hello-world"; break;
                case 2: strCodePreset = "preset.input.text"; break;
                case 3: strCodePreset = "preset.input.int"; break;
                case 4: strCodePreset = "preset.input.float"; break;
                case 5: strCodePreset = "preset.input.double"; break;
            }

            functionCodePresets.CodePresetSwitch(strCodePreset);

            program.DoReturn(false);
        }

        public void ClassCreation()
        {
            var className = "";
            var classPreaset = 0;
            var strClassPreset = "";

            wipThrow.ThrowWIP("feature", true);

            program.DoReturn(false);
        }

        public void StructCreation()
        {
            // throwError.WIPThrow(true, "feature");

            wipThrow.ThrowWIP("feature", true);

            program.DoReturn(false);
        }

        public void InterfaceCreation()
        {
            // throwError.WIPThrow(true, "feature");

            wipThrow.ThrowWIP("feature", true);

            program.DoReturn(false);
        }
    }
}