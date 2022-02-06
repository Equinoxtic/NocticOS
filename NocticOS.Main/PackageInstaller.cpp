/*
This (C++) file is used for Package Installation
Read, "COMPILING.md" to learn how to compile this (C++) file
*/

#include <iostream>

using namespace std;

void PackageSelection();
void InstallPackage(int cur_package = 0);
void UninstallPackage(int cur_package = 0);

int main()
{
	string options;

	string daOptions[3] = {};

	cout << "Select an Option:\n";

	for (int i = 0; i < 3; i++) {
		cout << daOptions[i];
	}

	cin >> options;

	switch(options)
	{
		case 1:
			PackageSelection();
			break;

		case 2:
			InstallPackage();
			break;
		
		case 3:
			UninstallPackage();
			break;
	}

	return 0;
}
