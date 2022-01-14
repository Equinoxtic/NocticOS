namespace NocticOS.NocticBase.Sources.UtilityCommands
{
    public class CmdList
    {
        public void ExecCmdList()
        {
            string[] strCmdList = {
                "-h", "-l"
            };

            Console.WriteLine("All valid NocticOS commands:\n");

            Console.WriteLine(
                "\n" + strCmdList[0] + "\n" +
                strCmdList[1] + "\n"
            );
        }
    }
}