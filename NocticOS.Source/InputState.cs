using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.Source
{
    public class InputState
    {
        public string InputType = "";
        StandardInput DaInput = new StandardInput();
        public void InputSelect()
        {
            var DaInputType = this.InputType;

            string[] InputTypeList = {
                "[str] String | ",
                "[int] Integer | ",
                "[dbl] Double"
            };

            Console.Write("Select a type for input:\n");
            DaInputType = Console.ReadLine();

            for (int i = 0; i < 3; i++) {
                Console.Write(InputTypeList[i]);
            }

            InputSwitch("switch_type_one");
        }

        public void InputSwitch(string SwitchType)
        {
            if (SwitchType == "switch_type_one")
            {
                switch(InputType)
                {
                    case "str":
                        DaInput.InputStr();
                        break;
                }
            }

            if (SwitchType == "switch_type_two")
            {
                switch(InputType)
                {
                    case "str_case":
                        DaInput.InputStr();
                        break;
                }
            }
        }
    }
}