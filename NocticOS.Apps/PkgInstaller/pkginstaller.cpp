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
		cout << options[i];
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