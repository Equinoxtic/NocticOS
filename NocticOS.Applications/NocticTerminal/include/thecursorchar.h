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
		printf("> ");
		break;

		case 2:
		printf("~ ");
		break;

		case 3:
		printf("- ");
		break;

		case 4:
		printf("[>>>]: ");
		break;

		case 5:
		printf("$ ")
		break;
	}
}

#define
