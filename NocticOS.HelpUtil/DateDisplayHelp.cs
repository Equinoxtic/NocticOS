using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.HelpUtil
{
    public class DateDisplayHelp
    {
        ThrowError throwError = new ThrowError();
        public void OpenHelp(bool isMissingParams)
        {
            ProgramReturn Program = new ProgramReturn();

            string[] dateDisplayLs = {
                "-t - Displays the current time.",
                "-help - Shows the available commands for 'day'",
                "-d - Displays the current date.",
                "-cur - Displays the current month, date and time."
            };

            /*
            string[] dateDisplayDescs = {
                " - Displays the current time.",
                " - Shows the available commands for 'day'",
                " - Displays the current date.",
                " - Displays the current month, date and time."
            };
            */

            if (isMissingParams) {
                throwError.MissingParamsThrow(true);   
            }

            Console.Write("\n");

            for (int i = 0; i < dateDisplayLs.Length; i++) {
                if (isMissingParams) {
                    Console.Write("day " + dateDisplayLs[i] + "\n");
                } else {
                    Console.Write(dateDisplayLs[i] + "\n");
                }
            }

            Program.DoReturn(false);
        }
    }
}