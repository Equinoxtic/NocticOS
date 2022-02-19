// compilecppfiles.h

#include<iostream>

using namespace std;

void CompileCPPFiles()
{
	system("cd..");
	system("cd..");
	system("cd PkgInstaller");
	system("g++ pkginstaller.cpp -o pkginstaller.exe");
	system("cd..");
	system("cd V-Script");
	system("g++ vscript.cpp -o vscript.exe");
}
