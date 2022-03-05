using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Utility
{
    public class StandardMath
    {
        public void NocticMath(string oper, bool includeInput, int a = 0, int b = 0)
        {
            Program program = new Program();

            if (includeInput)
            {
                Console.Write("\nEnter your first number: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your second number: ");
                b = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Result: ");

            switch(oper)
            {
                case "add" : Console.Write(a+b); break;
                case "subtract" : Console.Write(a-b); break;
                case "multiply" : Console.Write(a*b); break;
                case "divide" : Console.Write(a/b); break;
            }

            Console.Write("\n");
            
            program.DoReturn(false);
        }
    }
}