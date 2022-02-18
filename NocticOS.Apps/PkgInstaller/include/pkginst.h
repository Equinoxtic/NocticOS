// pkginst.h

#include<iostream>
#include<bits/stdc++.h>

using namespace std;

void InstallPackage()
{
	string curRepo = "";
	cout << "Enter a Repository link to install: ";
	cin >> curRepo;
	string str = "git ";
	str = str + "clone " + curRepo;
	const char* command = str.c_str();
	system(command);
}
