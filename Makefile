all:
	windres src\resources.rc artifacts\res.o
	g++ -Wl,-subsystem,windows -o bin\ShadowBrowser.exe -Llib -lShadowCore -Iinclude artifacts\res.o src\main.cpp
	copy lib\ShadowCore.dll bin\ShadowCore.dll