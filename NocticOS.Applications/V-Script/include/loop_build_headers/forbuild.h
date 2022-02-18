// forbuild.h

#include "throwutility.h"
#include<iostream>

using namespace std;

void ForInit(int ivar, int a, string outputStr)
{
	for (int i = ivar; i < a; i++) {
		cout << outputStr;
	}
	ThrowPause();
}
