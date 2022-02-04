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

namespace NocticOS.Source
{
    public class CreationState
    {
        public void OpenState()
        {
            CustomCreation customCreation = new CustomCreation();

            string[] customTypeTags = {
                "[obj] - ",
                "[func] - ",
                "[class] - "
            };

            string[] customTypeDescs = {
                "Create a Custom Object.",
                "Create a Custom Function.",
                "Create a Custom Class."
            };

            var customType = "";

            Console.Write("\nSelect an action:\n");

            for (int i = 0; i < 3; i++) {
                Console.Write(customTypeTags[i] + customTypeDescs[i] + "\n");
            }

            Console.Write("~ ");
            
            customType = Console.ReadLine();

            switch(customType)
            {
                case "obj": customCreation.ObjectCreation(); break;
                case "func" : customCreation.FunctionCreation(); break;
                case "class" : customCreation.ClassCreation(); break;
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
            }
        }
    }
}