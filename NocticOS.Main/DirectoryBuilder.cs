using System;
using System.IO;

namespace NocticOS.Main
{
    public class DirectoryBuilder
    {
        public void DirBuild()
        {
            Program program = new Program();

            var curDir = @"C:\NocticOS";

			string[] createDirs = {
				@"C:\NocticOS\Objects",
				@"C:\NocticOS\Functions",
				@"C:\NocticOS\Classes",
				@"C:\NocticOS\Data",
				@"C:\NocticOS\Packages"
			};

            System.IO.Directory.CreateDirectory(curDir);
			
		    if (System.IO.Directory.Exists(curDir)) {
				for (int i = 0; i < createDirs.Length; i++) {
					System.IO.Directory.CreateDirectory(createDirs[i]);
				}
			}

			Console.WriteLine("\nSuccessfully Built NocticOS directories.");

            program.DoReturn(false);
        }
    }
}