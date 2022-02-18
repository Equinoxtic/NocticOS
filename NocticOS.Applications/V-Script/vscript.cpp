// vscript.cpp

#include "include/throwutility.h"
#include "include/vcalc.h"
#include "include/loopbuild.h"
#include<iostream>

using namespace std;

int main()
{
	int curOption;

	string options[1] = {
		"[1] Calculator",
		"[2] Loop builder",
	};

	cout << "=== V-Script ===\nSelect an action:\n";

	for (int i = 0; i < 1; i++) {
		cout << options[i] + "\n";
	}

	cin >> curOption;

	switch(curOption)
	{
		case 1:
			StartCalculator();
			break;
		case 2:
			LoopBuilder();
			break;
	}

	ThrowPause();

	return 0;
}
