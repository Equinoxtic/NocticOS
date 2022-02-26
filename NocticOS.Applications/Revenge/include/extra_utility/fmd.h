// fmd.h

#ifndef FMD_H
#define FMD_H

#include <stdio.h>
#include <stdlib.h>

void ForceMute()
{
	int targID;
	printf("Input a user ID: ");
	scanf("%i", targID);
	printf("User ID: ", targID, " muted.");
}

void ForceDeafen()
{
	int targID;
	printf("Input a user ID: ");
	scanf("%i", targID);
	printf("User ID: ", targID, " deafened.");
}

#endif
