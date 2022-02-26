// revengesettings.h

#ifndef REVENGESETTINGS_H
#define REVENGESETTINGS_H

#include "revengeprefs.h"
#include "cursorchar.h"
#include<iostream>

using namespace std;

RevengePrefs revengePrefs;

void OpenRevengeSettings()
{
	int curOption;
	string currentCursor = revengePrefs.cursorCharacter;
	string nukePreference = revengePrefs.nukePref;
	bool unliSpam = revengePrefs.unlimitedSpam;

	string configLs[3] = {
		"[1] - Change Cursor",
		"[2] - Nuke Preferences",
		"[3] - Set Spam Limit"
	};

	for (int i = 0; i < 3; i++) {
		cout << configLs[i] + "\n";
	}

	SwapCursorChar("~ ", true);

	cin >> curOption;
}

#endif