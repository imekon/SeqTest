#include <windows.h>

#include "MIDINativeConfiguration.h"

using namespace std;

MIDINativeConfiguration::MIDINativeConfiguration()
{
	
}

int MIDINativeConfiguration::GetNumOutputDevices()
{
	return midiOutGetNumDevs();
}

std::wstring MIDINativeConfiguration::GetOutputDeviceName(int device)
{
	MIDIOUTCAPS caps;

	midiOutGetDevCaps(device, &caps, sizeof(MIDIOUTCAPS));

	return caps.szPname;
}
