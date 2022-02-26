// cursorchar.h

#ifndef CURSORCHAR_H
#define CURSORCHAR_H

#include<iostream>
#include<string>

using namespace std;

void SwapCursorChar(string curCursorChar, bool addNewLine) {
    if (addNewLine == true) {
        cout << "\n";
    }
    cout << curCursorChar;
}

#endif
