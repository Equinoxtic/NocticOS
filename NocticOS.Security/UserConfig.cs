using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS.Security
{
    public class UserConfig
    {
        UserPrefs userPrefs = new UserPrefs();
        string? un = "";
        string? pw = "";
        string[] userConfigList = {
            "[name] - Configurate username",
            "[pass] - Configurate user password",
            "[back] - Go back"
        };

        public void UserConfigPrompt() {
            Program program = new Program();
            Options userOptionsList = new Options();
            string? choice = "";
            Console.Write("\n");
            userOptionsList.PushOptions(userConfigList, userConfigList.Length);
            choice = Console.ReadLine();
            if (String.IsNullOrEmpty(choice)) {
                Throw emptyValue = new Throw();
                emptyValue.CreateThrow(
                    false,
                    "ev",
                    "Empty value. Please try again.",
                    true
                );
                program.DoReturn(false);
            }
        }

        public void SwitchConfigState(string state) {
            switch(state) {
                case "name" or "username":
                    ConfigState("name");
                    break;
                case "pass" or "password":
                    ConfigState("pass");
                    break;
                case "back":
                    ConfigState("back");
                    break;
            }
        }

        void ConfigState(string curState) 
        {
            Program program = new Program();
            string statePrefix = "";
            string? choice = "";
            bool isConfig = true;
            switch(curState) {
                case "name" or "username":
                    statePrefix = "Username";
                    break;
                case "pass" or "password":
                    statePrefix = "Password";
                    break;
                case "back":
                    isConfig = false;
                    break;
            }
            if (isConfig)
            {
                Console.Write(statePrefix + " configuration.");
                Console.Write("\nEnter your " + statePrefix);
                switch(curState) {
                    case "name" or "username":
                        un =  Console.ReadLine();
                        userPrefs.username = un;
                        break;
                    case "pass" or "password":
                        pw = Console.ReadLine();
                        userPrefs.userpw = pw;
                        break;
                }
            }
            else
            {
                Console.Write("Are you sure you want to exit out of this operation? [Y/N]: ");
                choice = Console.ReadLine();
                if (String.IsNullOrEmpty(choice)) {
                    Throw emtpyValue = new Throw();
                    emtpyValue.CreateThrow(
                        false,
                        "ev",
                        "Empty value, please try again.",
                        true
                    );
                    program.DoReturn(false);
                } else {
                    switch(choice) {
                        case "Y" or "y":
                            program.DoReturn(false);
                            break;
                        case "N" or "n":
                            UserConfigPrompt();
                            break;
                    }
                }
            }
            program.DoReturn(false);
        }
    }
}