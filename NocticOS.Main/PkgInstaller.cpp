#include <iostream>

using namespace std;

void InstallPackages();
void UninstallPackages();

int main()
{
	int action;
	
	string actionsLs[2] = {
		"[1] Install Packages",
		"[2] Uninstall Packages"
	};

	for (int i = 0; i < 2; i++) {
		cout << actionsLs[i];
	}

	cout << "\n";

	cin >> action;

	switch(action)
	{}

	return 0;
}

void InstallPackages()
{
	string packagels[2] = {
		"dotnet add .\\NocticOS.csproj Newtonsoft.Json",
		"dotnet add .\\NocticOS.csproj NodaTime"
	};

	for (int i = 0; i < 2; i++) {
		system(packagels[i]);
	}
}

void UninstallPackages()
{
	string packagels[2] = {
		"dotnet remove .\\NocticOS.csproj Newtonsoft.Json",
		"dotnet remove .\\NocticOS.csproj NodaTime"
	};

	for (int i = 0; i < 2; i++) {
		system(packagels[i]);
	}
}
