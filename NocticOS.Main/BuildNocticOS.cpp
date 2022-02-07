#include <iostream>

using namespace std;

int main()
{
	string options;

	cout << "Build NocticOS? [y/n]: ";

	cin >> options;

	if (options == "y" || options == "Y") {
		system("dotnet build .\\NocticOS.csproj");
	}
	
	return 0;
}