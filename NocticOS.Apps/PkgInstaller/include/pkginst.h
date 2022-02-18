// include/pkginst.h

#include<iostream>

using namespace std;

void InstallPackage()
{
	// Input and Output
	char curRepoLink[100];
	cout << "Enter a repository link to install: ";
	cin.getline(curRepoLink, 100);

	// Cloning
	string str = "git clone ";
	str = str + curRepoLink;
	const char *command = str.c_str();

	// Run command
	system(command);
}
