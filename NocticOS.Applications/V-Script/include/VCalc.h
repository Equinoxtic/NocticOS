// VCalc.h

#include "VMath.h"
#include<iostream>

using namespace std;

void StartCalculator()
{
	int fnum;
	int snum;
	int curOper;

	cout << "=== V-Script Calculator ===\n";

	cout << "Input your first number: ";
	cin >> fnum;
	cout << "Input your second number: ";
	cin >> snum;

	cout << "Select an operation:\n";

	string operls[4] = {
		"[1] Addition",
		"[2] Subtraction",
		"[3] Multiplication",
		"[4] Division"
	};

	for (int i = 0; i < 4; i++) {
		cout << operls[i] + "\n";
	}

	cin >> curOper;

	switch (curOper)
	{
		case 1:
			OperSwitch("add", fnum, snum);
			break;
		case 2:
			OperSwitch("subtract", fnum, snum);
			break;
		case 3:
			OperSwitch("multiply", fnum, snum);
			break;
		case 4:
			OperSwitch("divide", fnum, snum);
			break;
	}
}
