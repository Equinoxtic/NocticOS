/*
This (C++) file is used for Package Installation
Read, "COMPILING.md" to learn how to compile this (C++) file
*/

#include <iostream>

using namespace std;

// Install Functions
void InstallPackage(int cur_package = 0)
{
	/* No code yet. */
}

void InstallPackagePrompt(int curPackage = 0)
{
	/* No code yet. */
}


// Uninstall Functions
void UninstallPackage(int cur_package = 0)
{
	/* No code yet. */
}

void UninstallPackagePrompt(int curPackage = 0)
{
	/* No code yet. */
}


// Main
int main()
{
	string options;
	int currentPackage;

	string the_options[1] = {
		"Newtonsoft.Json"
	};

	cout << "Select a package to install:\n";

	for (int i = 0; i < 1; i++) {
		cout << the_options[i];
	}

	cin >> options;

	switch(options)
	{
		case 1:
			currentPackage = 1;
			break;
	}

	return 0;
}
