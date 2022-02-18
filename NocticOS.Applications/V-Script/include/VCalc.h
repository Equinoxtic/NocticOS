// VCalc.h

#include "VCalc.h"
#include<iostream>

using namespace std;

class VCalc
{
	public:
		void OpenCalc()
		{
			int fnum;
			int snum;
			int curOper;

			cout << "=== V-Script Calculator ===\n\nSelect an Operation";
			
			string operls[4] = {
				"[1] Add",
				"[2] Subtract",
				"[3] Multiply",
				"[4] Divide"
			};

			for (int i = 0; i < 4; i++) {
				cout << operls[i] + "\n";
			}

			cin >> curOper;

			cout << "\nInput your first number: ";
			cin >> fnum;
			cout << "\nInput your second number: ";
			cin >> snum;

			switch(curOper)
			{
				case 1:
					Math::add(fnum, snum);
					break;
				case 2:
					Math::sub(fnum, snum);
					break;
				case 3:
					Math::mul(fnum, snum);
					break;
				case 4:
					Math::div(fnum, snum);
					break;
			}
		}
};

VCalc Calculator;
