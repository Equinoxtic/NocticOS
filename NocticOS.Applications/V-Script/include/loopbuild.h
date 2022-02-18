// loopbuild.cpp

#include "loop_build_headers/whilebuild.h"
#include<iostream>

using namespace std;

void LoopBuilder()
{
	int curOpt;

	string options[2] = {
		"[1] For",
		"[2] While"
	};
	
	cout << "=== V-Script Loop Builder ===\n"

	cout << "Select an action:\n";

	for (int i = 0; i < 2; i++) {
		cout << options[i] + "\n";
	}

	cin >> curOpt;

	switch(curOpt)
	{
		case 1:
		case 2:
			CinWhile();
			break;
	}
}
