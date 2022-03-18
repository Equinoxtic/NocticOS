using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS.Source
{
    public class MainConsole
    {
        static string mainPath = "Home/";
        static string choice = "";
        ConsoleCommandSwitch consoleCommandSwitch = new ConsoleCommandSwitch();
        public void OpenConsole()
        {   
            Console.Write("\n" + mainPath + "> ");
            choice = Console.ReadLine();
            consoleCommandSwitch.DoSwitch(choice);
        }
    }
}