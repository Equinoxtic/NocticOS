using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Lib
{
    public class ConsoleCommandSwitch
    {
        Program program = new Program();
        public void DoSwitch(string choice)
        {
            switch (choice)
            {
                case "exit" or "out" or "back": program.DoReturn(false); break;
            }
        }
    }
}