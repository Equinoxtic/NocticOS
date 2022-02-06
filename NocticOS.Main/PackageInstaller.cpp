/*
This (C++) file is used for Package Installation
Read, "COMPILING.md" to learn how to compile this (C++) file
*/

#include <iostream>

using namespace std;

void InstallPackage(int cur_package = 0)
{
	/* No code yet. */
}

void UninstallPackage(int cur_package = 0)
{
	/* No code yet. */
}	

int main()
{
	string options;

	string the_options[1] = {};

	cout << "Select a package to install:\n";

	for (int i = 0; i < 1; i++) {
		cout << the_options[i];
	}

	cin >> options;

	return 0;
}
