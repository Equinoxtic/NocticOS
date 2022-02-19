// updateproj.h

#include<iostream>

using namespace std;

void UpdateProject()
{
	cout << "NOTICE: This will get the LATEST version of NocticOS.";
	string curRepo = "https://github.com/Equinoxtic/NocticOS";
	string str = "git ";
	str = str + "clone " + curRepo;
	const char* command = str.c_str();
	system(command);
	system("pause");
}
