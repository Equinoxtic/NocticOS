// pkginst.h

#include<iostream>

using namespace std;

void InstallPackage(string curRepoLink)
{
	/*
	Check if repo link is null
	*/
	if (curRepoLink != NULL) {
		system("git clone " + curRepoLink);
		return 0;
	} else {
		cout << "Failed to install, please try again.";
		return 1;
	}
}
