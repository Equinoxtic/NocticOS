// taskbar.h

#ifndef TASKBAR_H
#define TASKBAR_H

#include<iostream>

using namespace std;

void CreateTaskbar()
{
	string tags[3] = {
		"[-file] ",
		"[-view] ",
		"[-help] ",
	};

	string names[3] = {
		"File",
		"View",
		"Help"
	};

	for (int i = 0; i < 3; i++) {
		cout << tags[i] + names[i] + "\n";
	}
}

#endif
