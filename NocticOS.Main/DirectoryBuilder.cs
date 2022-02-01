using System;
using System.IO;

namespace NocticOS.Main
{
    public class DirectoryBuilder
    {
        public void DirBuild()
        {
            ProgramReturn ReturnToProgram = new ProgramReturn();

            var curDir = @"C:\NocticOS";

			string[] createDirs = {
				@"C:\NocticOS\Objects",
				@"C:\NocticOS\Functions",
				@"C:\NocticOS\Classes",
				@"C:\NocticOS\Data"
			};

            System.IO.Directory.CreateDirectory(curDir);
			
		    if (System.IO.Directory.Exists(curDir)) {
				for (int i = 0; i < 3; i++) {
					System.IO.Directory.CreateDirectory(createDirs[i]);
				}
			}

			Console.WriteLine("\nSuccessfully Built NocticOS directories.");

            ReturnToProgram.DoReturn(false);
        }
    }
}