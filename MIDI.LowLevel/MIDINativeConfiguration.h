#pragma once

#include <string>

#include "MIDINative.h"

class EXTERNAL MIDINativeConfiguration
{
public:
	MIDINativeConfiguration();

	int GetNumOutputDevices();
	std::wstring GetOutputDeviceName(int device);
};
