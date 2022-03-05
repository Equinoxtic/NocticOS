using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Settings
{
    public class ConsoleProperties
    {
        ConsolePrefs consolePrefs = new ConsolePrefs();

        public void ConsoleSettingsState()
        {
            Program program = new Program();

            program.DoReturn(false);
        }
    }
}