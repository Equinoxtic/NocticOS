// throwutility.h

#ifndef THROWUTILITY_H
#define THROWUTILITY_H

#include<stdio.h>
#include<stdlib.h>

int wipThrow();
int ocThrow();

int throwSwitch(int curThrow)
{
	switch(curThrow)
	{
		case 1:
		wipThrow();
		break;

		case 2:
		ocThrow();
		break;
	}
}

int wipThrow()
{
	printf("This feature is a work in progress.");
}

int ocThrow()
{
	printf("Operation Cancelled.");
}

#endif
