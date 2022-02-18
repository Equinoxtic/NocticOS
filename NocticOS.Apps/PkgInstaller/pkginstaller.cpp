// PkgInstaller.c

#include <iostream>

#include "include/pkginst.h"

int main()
{
	int option = 0;

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
			InstallPackage();
			break;

		case 2:
			cout << "do nothin";
			break;
	}
}
