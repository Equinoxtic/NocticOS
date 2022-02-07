/*
This (C++) file is used for Package Installation
Read, "COMPILING.md" to learn how to compile this (C++) file
*/

#include <iostream>
#include <stdlib.h>
#include <shlobj.h>
#include <shlwapi.h>
#include <objbase.h>

using namespace std;

// Install Functions
void InstallPackage(int cur_package = 0, string thePackage = "")
{
	switch (cur_package)
	{
		case 1:
			ShellExecute("C:\\NocticOS\\");
			break;
	}
}

void InstallPackagePrompt(int curPackage = 0, string PackageName = "")
{
	string options;

	cout << "\nWould you like to install " + PackageName + "? [y/n]: ";

	cin >> options;

	if (options == "y" || options == "Y") {
		InstallPackage(curPackage, PackageName);
	} else if (options == "n" || options == "N") {
		cout << "Operation Cancelled.";
	} else {
		cout << "Unknown Character.";
	}
}


// Uninstall Functions
void UninstallPackage(int cur_package = 0, string thePackage = "")
{
	/* No code yet. */
}

void UninstallPackagePrompt(int curPackage = 0, string PackageName = "")
{
	string options;

	cout << "\nWould you like to uninstall " + PackageName + "? [y/n]: ";

	cin >> options;

	if (options == "y" || options == "Y") {
		UninstallPackage(curPackage);
	} else if (options == "n" || options == "N") {
		cout << "Operation Cancelled.";
	} else {
		cout << "Unknown Character.";
	}
}


// Main
int main()
{
	int options;

	int currentPackage;

	string the_options[1] = {
		"[1] Newtonsoft.Json"
	};

	cout << "Select a package to install:\n";

	for (int i = 0; i < 1; i++) {
		cout << the_options[i];
	}

	cout << "\n";

	cin >> options;

	switch(options)
	{
		case 1:
			currentPackage = 1;
			InstallPackagePrompt(1, the_options[0]);
			break;
	}

	return 0;
}
