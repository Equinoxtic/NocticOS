// revenge.cpp

// Logger includes

// Spamming stuff

// PRE-NUKE

// Other
#include "include/taskbar.h"
#include "include/cursorchar.h"

#include<iostream>
#include<string>

using namespace std;

/*
void cmdSwitch(int curCommand)
{
	switch(curCommand)
	{
	}
}
*/

int main()
{
	int curOption;

	cout << R"(
	 ______     ______     __   __   ______     __   __     ______     ______    
	/\  == \   /\  ___\   /\ \ / /  /\  ___\   /\ "-.\ \   /\  ___\   /\  ___\
	\ \  __<   \ \  __\   \ \ \'/   \ \  __\   \ \ \-.  \  \ \ \__ \  \ \  __\
	 \ \_\ \_\  \ \_____\  \ \__|    \ \_____\  \ \_\\"\_\  \ \_____\  \ \_____\
	  \/_/ /_/   \/_____/   \/_/      \/_____/   \/_/ \/_/   \/_____/   \/_____/
                                                                             
	)" << "\n";

	cout << "	----------------------------------------------------------------------------\n\n";

	string optionsLsFirstRow[15] = {
		"		USER CONTROL",
		"		[1] Log into User",
		"		[2] DM Annoyance (Spam DMs)",
		"		[3] User Token Grabber",
		"		[4] Force Disable / Delete",
		"\n		MALWARE INJECTS",
		"		[4] Malware Inject for Images",
		"		[5] Malware Inject for Spoilered messages",
		"		[6] Malware Inject for Sent Links",
		"		[7] Target user for Malware Inject",
		"\n		EXTRA UTILITY",
		"		[8] FMD (Force Server Mute and Defean)",
		"		[9] Force User to send a message",
		"		[10] Force User to open a link",
		"		[11] Get Information from a targetted User"
	};

	string optionsLsSecondRow[14] = {
		"		SERVER CONTROL",
		"		[11] Spam-Create Channel",
		"		[12] Spam-Create Roles",
		"		[13] Spam Ping",
		"		[14] Mass Kick Users",
		"		[15] Mass Ban Users",
		"		[16] Nuke Server",
		"\n		MISCELLANEOUS",
		"		[17] Nuke a targetted server",
		"		[18] Wipe all roles and channels",
		"		[19] Change Server Properties",
		"		[20] Webhook Management",
		"		[21] Delete all channels and roles",
		"		[22] Disconnect User from a voice channel"
	};

	for (int i = 0; i < 15; i++) {
		cout << optionsLsFirstRow[i] + "\n";
	}

	cout << "\n	----------------------------------------------------------------------------\n\n";

	for (int i = 0; i < 14; i++) {
		cout << optionsLsSecondRow[i] + "\n";
	}

	cout << "\n	----------------------------------------------------------------------------\n\n";

	TaskbarCreate();

	SwapCursorChar("[>>>]: ", true);

	cin >> curOption;

	return 0;
}