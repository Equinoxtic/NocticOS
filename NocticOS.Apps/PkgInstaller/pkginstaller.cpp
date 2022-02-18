// PkgInstaller.c

#include <iostream>

#include "pkginst.h"

void main()
{
	string option = "";

	string options[2] = {
		"[1] Install",
		"[2] Uninstall"
	};

	for (int i = 0; i < 2; i++) {
		cout << options[i] + "\n";
	}

	cin >> option;

	switch(option)
	{
		case 1:
			StartInstall();
			break;

		case 2:
			StartUninstall();
			break;
	}

}

void StartInstall()
{
	string repoLink = "";
	cout << "Enter a repository link to install: ";
	cin >> repoLink;
	InstallPackage(repoLink);
}

void StartUninstall()
{}
