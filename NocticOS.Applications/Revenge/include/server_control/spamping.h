// spamping.h

#ifndef SPAMPING_H
#define SPAMPING_H

#include<iostream>
#include<string>

using namespace std;

void SpamMsg(int spamLength, string curMsg) {
	for (int i = 0; i < spamLength; i++) {
		cout << curMsg;
	}
}

#endif
