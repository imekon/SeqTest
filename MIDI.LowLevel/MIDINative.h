#pragma once

#ifdef _MIDILowLevelLibrary
#define EXTERNAL __declspec(dllexport)
#else
#define EXTERNAL __declspec(dllimport)
#endif

