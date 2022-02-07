#include <iostream>

using namespace std;

int main()
{
	int action;
	
	string actionsLs[2] = {
		"[1] Install Packages",
		"[2] Uninstall Packages"
	};

	for (int i = 0; i < 2; i++) {
		cout << actionsLs[i];
	}

	cout << "\n";

	cin >> action;

	switch(action)
	{}

	return 0;
}