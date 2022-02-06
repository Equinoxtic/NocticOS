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
	PackageSelection();
	return 0;
}
