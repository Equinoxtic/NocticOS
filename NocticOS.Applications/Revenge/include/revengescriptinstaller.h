// revengescriptinstaller.h

#ifndef REVENGESCRIPTINSTALLER_H
#define REVENGESCRIPTINSTALLER_H

#include<iostream>
#include<string>

using namespace std;

void RevengeScriptInstaller()
{
	string curScriptLink = "";
    cout << "Enter the script link to install: ";
    cin >> curScriptLink;
    string str = "git ";
    str = str + "clone " + curScriptLink;
    const char* command = str.c_str();
    system(command);
    system("pause");
}

#endif
