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

namespace NocticOS.Utility
{
    public class CustomCreation
    {
        ThrowError throwError = new ThrowError();
        public void ObjectCreation()
        {
            ProgramReturn Program = new ProgramReturn();
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

            Program.DoReturn(false);
        }
        
        public string functionPreset = "";

        public void FunctionCreation()
        {
            ProgramReturn Program = new ProgramReturn();
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

            functionName = Console.ReadLine();

            functionArgLength = Convert.ToInt32(Console.ReadLine());

            string[] functionArguments = new string[functionArgLength];

            for (int i = 0; i < functionArgLength; i++) {
                functionArguments[i] = Console.ReadLine();
            }

            for (int i = 0; i < presetLs.Length; i++) {
                Console.Write(presetLs[i] + "\n");
            }

            functionCodePreset = Convert.ToInt32(Console.ReadLine());

            switch(functionCodePreset)
            {
                case 1: strCodePreset = "preset.print-hello-word"; break;
                case 2: strCodePreset = "preset.input.text"; break;
                case 3: strCodePreset = "preset.input.int"; break;
                case 4: strCodePreset = "preset.input.float"; break;
                case 5: strCodePreset = "preset.input.double"; break;
            }

            functionCodePresets.CodePresetSwitch(strCodePreset);

            Program.DoReturn(false);
        }

        public void ClassCreation()
        {
            ProgramReturn Program = new ProgramReturn();

            var className = "";
            var classPreaset = 0;
            var strClassPreset = "";

            Program.DoReturn(false);
        }

        public void StructCreation()
        {
            ProgramReturn Program = new ProgramReturn();

            throwError.WIPThrow(true, "feature");

            Program.DoReturn(false);
        }

        public void InterfaceCreation()
        {
            ProgramReturn Program = new ProgramReturn();

            throwError.WIPThrow(true, "feature");

            Program.DoReturn(false);
        }
    }
}