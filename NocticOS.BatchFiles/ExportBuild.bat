:: Batch Script for Exporting

ECHO Exporting Project...

CD..
dotnet build
CD bin/Debug/net6.0
MKDIR external_apps
CD..
CD..
CD..
CD NocticOS.Applications
CD NocticCompiler
g++ nocticcompiler.cpp -o nocticcompiler.exe
g++ nocticupdater.cpp -o nocticupdater.exe
MOVE *.exe ~/bin/Debug/net6.0/external_apps
CD..
CD PkgInstaller
g++ pkginstaller.cpp -o pkginstaller.exe
MOVE pkginstaller.exe ~/bin/Debug/net6.0/external_apps
CD..
CD Revenge
g++ revenge.cpp -o revenge.exe
MOVE revenge.exe ~/bin/Debug/net6.0/external_apps
CD..
CD Revenge-PY
.\pyinstaller --onefile -w 'revenge.py'
MOVE revenge.py ~/bin/Debug/net6.0/external_apps
CD V-Script
g++ vscript.cpp -o vscript.exe
MOVE vscript.exe ~/bin/Debug/net6.0/external_apps
