// VMath.h

#include<iostream>

using namespace std;

void OperSwitch(string operation, int a, int b)
{
	if (operation == "add") {
		cout << a + b;
	}

	if (operation == "subtract") {
		cout << a - b;
	}

	if (operation == "multiply") {
		cout << a * b;
	}

	if (operation == "divide") {
		cout << a / b;
	}
}
