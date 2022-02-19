// nocticupdater.cpp

#include "include/updateproj.h"
#include<iostream>
#include<bits/stdc++.h>

using namespace std;

int main()
{
	string curOption;
	cout << "Run the update process? [y/n]: ";
	cin >> curOption;

	if (curOption == "y" || curOption == "Y") {
		UpdateProject();
	} else if (curOption == "n" || curOption == "N") {
		cout << "Operation Cancelled.";
	} else {
		cout << "Unknown Character.\n";
		system("pause");
	}
	return 0;
}
