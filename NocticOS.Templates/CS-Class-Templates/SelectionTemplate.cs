using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;
using NocticOS.Lib;
using NocticOS;

namespace NamespaceTemplate
{
    public class SelectionTemplate
    {
        public void SelectName(bool isMissingParams)
        {
            ProgramReturn Program = new ProgramReturn();
            Throw missingParams = new Throw();
            // ThrowError throwError = new ThrowError();

            string[] selectLs = {
                "cur - desc"
            };

            if (isMissingParams) {
                // throwError.MissingParamsThrow(true);
                missingParams.CreateThrow("mp",
                    "Missing Parameters. Please enter the following:",
                    true
                );
            }

            for (int i = 0; i < selectLs.Length; i++) {
                Console.Write(selectLs[i] + "\n");
            }

            Program.DoReturn(false);
        }
    }
}