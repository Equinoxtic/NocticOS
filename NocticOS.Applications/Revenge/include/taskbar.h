// taskbar.h

#ifndef TASKBAR_H
#define TASKBAR_H

#include<iostream>
#include<string>

using namespace std;

void TaskbarCreate()
{
	cout << "\n";

		string taskBarOpts[5] = {
		"	( ",
		"[23] Settings	|	",
		"[24] Script Installer	|	",
		"[25] Terminal", 
		" )"
	};

	for (int i = 0; i < 5; i++) {
		cout << taskBarOpts[i];
	}

	cout << "\n";
}

#endif
