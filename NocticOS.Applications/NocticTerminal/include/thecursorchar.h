// thecursorchar.h

#ifndef THECURSORCHAR_H
#define THECURSORCHAR_H

#include<stdio.h>
#include<stdlib.h>

int switchChar(int curCursor)
{
	switch(curCursor)
	{
		case 1:
		printf("\n> ");
		break;

		case 2:
		printf("\n~ ");
		break;

		case 3:
		printf("\n- ");
		break;

		case 4:
		printf("\n[>>>]: ");
		break;

		case 5:
		printf("\n~$ ")
		break;
	}
}

#define
