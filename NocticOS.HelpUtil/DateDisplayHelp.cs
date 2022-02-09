using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.HelpUtil
{
    public class DateDisplayHelp
    {
        public void OpenHelp(bool isMissingParams)
        {
            ProgramReturn Program = new ProgramReturn();

            string[] dateDisplayLs = {
                "-t",
                "-d",
                "-cur"
            };

            string[] dateDisplayDescs = {
                " - Displays the current time.",
                " - Displays the current date.",
                " - Displays the current month, date and time."
            };

            for (int i = 0; i < null; i++) {}

            Program.DoReturn(false);
        }
    }
}