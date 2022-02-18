// Main.cpp

#include "include/vmath.h"
#include<iostream>

using namespace std;

int main()
{
	int curOption;

	string options[1] = {
		"[1] Calculator"
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
	}

	return 0;
}
