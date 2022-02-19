// compileproj.h

#include<iostream>

using namespace std;

void CompileProject()
{
	system("cd..");
	system("cd..");
	string str = "dotnet ";
	str = str + "build";
	const char* command = str.c_str();
	system(command);
}
