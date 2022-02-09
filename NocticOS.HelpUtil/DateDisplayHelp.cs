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
                "-help",
                "-d",
                "-cur"
            };

            string[] dateDisplayDescs = {
                " - Displays the current time.",
                " - Shows the available commands for 'day'",
                " - Displays the current date.",
                " - Displays the current month, date and time."
            };

            if (isMissingParams) {
                Console.Write("\nMissing Parameters, please enter the following:\n");
            }

            for (int i = 0; i < 4; i++) {
                if (isMissingParams) {
                    Console.Write("day " + dateDisplayLs[i] + dateDisplayDescs[i] + "\n");
                } else {
                    Console.Write(dateDisplayLs[i] + dateDisplayDescs[i] + "\n");
                }
            }

            Program.DoReturn(false);
        }
    }
}