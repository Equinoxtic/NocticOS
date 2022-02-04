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

            switch(customType) {}
            for (int i = 0; i < 3; i++) {
                Console.Write(customTypeTags[i] + customTypeDescs[i] + "\n");
            }
        }
    }
}