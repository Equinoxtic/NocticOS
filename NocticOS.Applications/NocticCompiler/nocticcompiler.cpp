/*
New way of compiling NocticOS.
*/

// nocticcompiler.cpp

#include<iostream>

using namespace std;

int main()
{
	int curOption;

	string compileOptions[2] = {
		"[1] Compile NocticOS",
		"[2] Compile C++ files",
		"[3] Run NocticOS Updater"
	};

	for (int i = 0; i < 3; i++) {
		cout << compileOptions;
	}

	cin >> curOption;

	switch(curOption)
	{
		case 1:
		case 2:
		case 3:
	}

	cout << "\n";
	system("pause");

	return 0;
}
