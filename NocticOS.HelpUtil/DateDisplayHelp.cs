using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS.HelpUtil
{
    public class DateDisplayHelp
    {
        // ThrowError throwError = new ThrowError();
        Throw missingParams = new Throw();

        string[] dateDisplayLs = {
            "-help - Shows the available commands for 'day'",
            "-t - Outputs the current time.",
            "-d - Outputs the current date.",
            "-m - Outputs the current month.",
            "-y - Outputs the curretn year.",
            "-cur - Outputs the current month, date and time."
        };

        /*
        string[] dateDisplayDescs = {
            " - Displays the current time.",
            " - Shows the available commands for 'day'",
            " - Displays the current date.",
            " - Displays the current month, date and time."
        };
        */
        
        public void OpenHelp(bool isMissingParams)
        {
            Program program = new Program();

            if (isMissingParams) {
                // throwError.MissingParamsThrow(true);
                missingParams.CreateThrow(false, 
                    "mp",
                    "Missing Parameters. Please enter the following:",
                    true
                );
            }

            Console.Write("\n");

            for (int i = 0; i < dateDisplayLs.Length; i++) {
                if (isMissingParams) {
                    Console.Write("date " + dateDisplayLs[i] + "\n");
                } else {
                    Console.Write(dateDisplayLs[i] + "\n");
                }
            }

            program.DoReturn(false);
        }
    }
}