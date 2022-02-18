// PkgInstaller.cpp

#include "include/pkginst.h"
#include <iostream>
#include <bits/stdc++.h>

using namespace std;

int main()
{
	int option = 0;

	cout << "=== NocticOS package manager ===";

	cout << "\nSelect an action:\n";
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
	return 0;
}
