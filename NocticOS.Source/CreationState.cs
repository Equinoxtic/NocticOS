using System;

namespace NocticOS.Source
{
    public class CreationState
    {
        public void OpenState()
        {
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

            Console.Write("\nThis is still a BETA feature.\n");

            Console.Write("\nSelect an action:\n");

            for (int i = 0; i < 3; i++) {
                Console.Write(customTypeTags[i] + customTypeDescs[i] + "\n");
            }

            Console.Write("~ ");
            
            customType = Console.ReadLine();

            switch(customType){}
        }

        public void CreationSwitch(string createType)
        {
            switch (createType){}
        }
    }
}