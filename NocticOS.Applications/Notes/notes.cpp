// notes.cpp

#include<iostream>
#include "include/returnnotes.h"
#include "include/taskbar.h"

using namespace std;

int main(bool wantsReturn)
{
	CreateTaskbar();
	
	if (wantsReturn == true) {
		DoReturn();
	}

	return 0;
}
