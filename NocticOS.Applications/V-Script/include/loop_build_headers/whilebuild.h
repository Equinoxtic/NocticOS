// whilebuild.h

#include "throwutility.h"
#include<iostream>

using namespace std;

void WhileInit(int ivar, int a, int b)
{
	int i = ivar;
	while (i > a) {
		if (i == b) {
			break;
		}
	}
	ThrowPause();
}

void CinWhile()
{
	int ivar;
	int a;
	int b;
	string outputStr;
	
	cout << "int i = ";
	cin >> ivar;
	cout << "while (i > ";
	cin >> a;
	cout << "if (i == ";
	cin >> b;
	cout << "cout << ";
	cin >> outputStr;

	int i = ivar;

	while (i > a) {
		cout << outputStr;
		if (i == b) {
			break;
		}
	}
	ThrowPause();
}
