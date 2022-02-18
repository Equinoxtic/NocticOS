// forbuild.h

#include<loopthrows.h>
#include<iostream>

using namespace std;

void ForInit(int ivar, int a, string outputStr)
{
	for (int i = ivar; i < a; i++) {
		cout << outputStr;
	}
	ThrowPause();
}

void CinFor()
{
	int ivar;
	int a;
	string outputStr;

	cout << "int i = ";
	cin >> ivar;
	cout << "i < ";
	cin >> a;
	cout << "cout << ";
	cin >> outputStr;
	
	if (ivar == NULL || a == NULL || outputStr == NULL) {
		EmptyValueThrow();
	}

	for (int i = ivar; i < a; i++) {
		cout << outputStr;
	}

	ThrowPause();
}
