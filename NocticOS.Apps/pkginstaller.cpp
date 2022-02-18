// PkgInstaller.c

#include <iostream>

#include "pkginst.h"

void main()
{
	string repoLink = "";
	cout << "Enter a repository link to install: ";
	cin >> repoLink;
	InstallPackage(repoLink);
}
